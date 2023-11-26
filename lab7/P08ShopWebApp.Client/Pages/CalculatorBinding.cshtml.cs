using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P08ShopWebApp.Client.Pages
{
    public class CalculatorBindingModel : PageModel
    {
        [TempData]
        public int AdditionResult { get; set; }

        [TempData]
        public int SubstractionResult { get; set; }

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }
        
        public void OnGet()
        {
        }

        public void OnPostAdd() 
        {
            AdditionResult = Number1 + Number2;
        }

        public void OnPostSubstract()
        {
            SubstractionResult = Number1 - Number2;
        }
    }
}
