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
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public List<LostManken.Entities.Employee> Employee { get; set; }

        public ListModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }
        public void OnGet()
        {
            Employee = db.Employee.ToList();
        }
    }
}
