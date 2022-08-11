using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostManken.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LostManken.Areas.Admin.Pages.Products
{
    [Authorize]
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext db;

        public EditModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        [BindProperty]
        public Product Product { get; set; }
        public void OnGet(string id)
        {
            Product = db.Products.Find(id);
            var photos = db.ProductPhotos.Where(x => x.ProductId == Product.Id).ToList();
            Product.Photos = new List<ProductPhoto>();
            Product.Photos = photos;


        }

        public void OnPostUpdate()
        {
            var data = db.Products.Find(Product.Id);
            data.Name = Product.Name;
            data.UnitPrice = Product.UnitPrice;
            data.Stock = Product.Stock;
            data.Notes = Product.Notes;
            data.MainPhoto = Product.MainPhoto;
            data.Photos = Product.Photos;
            data.Properties = Product.Properties;

            int result = db.SaveChanges();

            if (result > 0)
                ViewData["Message"] = "Kayýt baþarýyla güncellendi";
            else
                ViewData["Message"] = "Lütfen tekrar deneyiniz";
        }
        public void OnPostDelete(int id)
        {
            var data = db.ProductPhotos.Find(id);
            System.IO.File.Delete(data.FileUrl);
            db.Remove(data);
            db.SaveChanges();
        }

    }
}
