using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostManken.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LostManken.Areas.Admin.Pages.Categories
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
        public Category Category { get; set; }
        
        public void OnGet(int id)
        {
            Category = db.Category.Find(id);
        }

        public void OnPostUpdate()
        {
            var data = db.Category.Find(Category.Id);
            data.CategoryName = Category.CategoryName;
            data.Description = Category.Description;

            int result = db.SaveChanges();

            if (result > 0)
                ViewData["Message"] = "Kay�t ba�ar�l� bir �ekilde g�ncellendi";
            else
                ViewData["Message"] = "L�tfen tekrar deneyiniz";
        }
    }
}
