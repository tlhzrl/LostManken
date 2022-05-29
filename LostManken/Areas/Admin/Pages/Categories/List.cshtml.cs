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
   
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public List<Category> Categories { get; set; }

        public ListModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void OnGet()
        {
            Categories = db.Category.ToList();
        }
    }
}
