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
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext applicationDb)
        {
            _db = applicationDb;
        }

        [BindProperty]
        public Category Category { get; set; }

        public void OnGet()
        {
          
        }

        public void OnPostCreate()
        {
            _db.Category.Add(Category);

            int result = _db.SaveChanges();

            if (result > 0)
                ViewData["Message"] = "Kay�t ba�ar�l� oldu";
            else
                ViewData["Message"] = "Tekrar deneyiniz";
        }
    }
}
