using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostManken.Entities;
using LostManken.Services.Upload;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LostManken.Areas.Admin.Pages.Products
{
    [Authorize]
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IFileUploader _fileUploader;

        public List<Product> ProductList { get; set; }

        [BindProperty]
        public List<IFormFile> files { get; set; }

        [BindProperty]
        public string SelectedProductId { get; set; }

        public ListModel(ApplicationDbContext applicationDbContext, IFileUploader fileUploader)
        {
            _applicationDbContext = applicationDbContext;
            _fileUploader = fileUploader;
        }
        public void OnGet()
        {
            ProductList = _applicationDbContext.Products.Include(x => x.Categories).Include(x => x.Photos).ToList();
        }



        public IActionResult OnPostAddPhotos()
        {
            foreach (IFormFile file in files)
            {
                var result = _fileUploader.Upload(file);

                if (result.FileResult == Services.Upload.FileResult.Succeded)
                {
                    var photo = new ProductPhoto
                    {
                        OrginalFileName = result.OriginalName,
                        ProductId = this.SelectedProductId,
                        FileUrl = result.FileUrl
                    };

                    _applicationDbContext.ProductPhotos.Add(photo);
                }
            }

            int dbresult = _applicationDbContext.SaveChanges();

            if (dbresult > 0)
            {
                TempData["Message"] = "Fotograflar ba�ar� ile y�klendi.";
            }

            return RedirectToPage("List");
        }
    }
}
