using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostManken.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LostManken.Areas.Admin.Pages.Employee
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public CreateModel(ApplicationDbContext applicationDbContext)
        {
            db = applicationDbContext;
        }
        [BindProperty]
        public LostManken.Entities.Employee Employee { get; set; }
        public void OnGet()
        {
        }

        public void OnPostCreate()
        {
            db.Employee.Add(Employee);

            int result = db.SaveChanges();

            if (result > 0)
            {
                ViewData["Message"] = "Müþteri kayýt tamamlandý";
            }
            else
            {
                ViewData["Message"] = "Tekrar deneyiniz";
            }
        }
    }
}
