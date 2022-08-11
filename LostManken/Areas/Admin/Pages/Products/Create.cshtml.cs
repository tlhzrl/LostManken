using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostManken.Entities;
using LostManken.Services;
using LostManken.Services.Upload;
using LostManken.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LostManken.Areas.Admin.Pages.Products
{
   
    public class CreateModel : PageModel
    {


        private readonly ApplicationDbContext context;
        private readonly ProductCreateValidator _createValidator;

        public CreateModel(ApplicationDbContext applicationDbContext, ProductCreateValidator createValidator)
        {
            context = applicationDbContext;
            _createValidator = createValidator;
        }

        [BindProperty]
        public Product Products { get; set; } = new Product();

        [BindProperty]
        public List<IFormFile> File { get; set; }

        public List<SelectListItem> CategoryList
        {
            
            get
            {
                var CategoryList = new List<SelectListItem>();
                CategoryList.Add(new SelectListItem { Text = "Se�im yap�n�z", Value = "" });

                var selected = context.Category.Select(a => new SelectListItem
                {

                    Text = a.CategoryName,
                    Value = a.Id.ToString()
                }
                ).ToList();

                CategoryList.AddRange(selected.ToArray());
                return CategoryList;
            }
        }

        public List<SelectListItem> Currenies
        {
            get
            {
                return new List<SelectListItem>() { 
                    new SelectListItem() { Text = "Dolar", Value = "1" },
                    new SelectListItem() { Text = "Euro", Value = "2" },
                    new SelectListItem() { Text = "TL", Value = "3" }
                };
            }
        }

        public void OnGet()
        {
            

            ViewData["Categories"] = CategoryList;
            ViewData["Currenies"] = Currenies;

            Products.MainPhoto = "";
        }

        public void OnPostCreate()
        {
            CategoryList.Add(new SelectListItem { Text = "Se�im yap�n�z", Value = null });
            ViewData["Categories"] = CategoryList;
            ViewData["Currenies"] = Currenies;


            //var uploader = new FileSystemFileUploader("Images");
            var uploader = new Base64FileUploader();
            //var result = uploader.Upload(File);

            var productService = new ProductService(uploader, context, _createValidator);

            var serviceResult = productService.CreateProduct(Products, File);
           

            

            //if (Products.MainPhoto == null)
            //{
            //    ModelState.AddModelError("MainPhoto", "Resim se�iniz");
            //}

            if (serviceResult.Succeded)
            {
                ViewData["Message"] = serviceResult.Message;
                ViewData["Succeded"] = serviceResult.Succeded;
            }
            else
            {
                ViewData["Message"] = String.Join(",", serviceResult.ErorList.ToArray());
            }
        }
    }

}
