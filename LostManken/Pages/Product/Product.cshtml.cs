using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LostManken.Pages.Product
{
    public class ProductModel : PageModel
    {
        public int CategoryId { get; set; }
        public void OnGet(int categoryId)
        {
            this.CategoryId = categoryId;
        }
    }
}
