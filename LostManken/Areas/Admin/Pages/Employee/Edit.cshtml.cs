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
  
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public EditModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        [BindProperty]
        public LostManken.Entities.Employee Employee { get; set; }

        public void OnGet(int id)
        {
            Employee = db.Employee.Find(id);
        }

        public void OnPostUpdate()
        {
            var data = db.Employee.Find(Employee.ID);
            data.CustomerName = Employee.CustomerName;
            data.CustomerSurname = Employee.CustomerSurname;
            data.CustomerEMail = Employee.CustomerEMail;
            data.CustomerAddress = Employee.CustomerAddress;
            data.PhoneNumber = Employee.PhoneNumber;

            int result = db.SaveChanges();

            if (result > 0)
                ViewData["Message"] = "Müþteri kayýdý baþarýlý bir þekilde güncellendi";
            else
                ViewData["Message"] = "Tekrar deneyiniz";
        }
    }
}

