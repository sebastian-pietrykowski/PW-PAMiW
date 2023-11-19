using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P08ShopWebApp.Client.Data;
using P08ShopWebApp.Client.Models;

namespace P08ShopWebApp.Client.Pages.ProductsAutoGen
{
    public class DetailsModel : PageModel
    {
        private readonly P08ShopWebApp.Client.Data.ShopContext _context;

        public DetailsModel(P08ShopWebApp.Client.Data.ShopContext context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
