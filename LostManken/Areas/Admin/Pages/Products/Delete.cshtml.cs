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
   
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public DeleteModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public string Id { get; set; }

        public void OnGet(string id)
        {
            this.Id = id;
        }


        public RedirectToPageResult OnPostDelete(string id)
        {
            var data = db.Products.FirstOrDefault(x => x.Id == id);
            db.Remove(data);
            db.SaveChanges();

            return RedirectToPage("List");
        }
    }
}
