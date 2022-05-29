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
   
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public DetailModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = db.Category.Find(id);
        }
    }
}
