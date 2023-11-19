using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P08ShopWebApp.Client.Pages
{
    public class CalculatorModel : PageModel
    {
        public int Result { get; set; }

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            var form = Request.Form;
            bool r1 = int.TryParse(form["Number1"], out int number1);
            bool r2 = int.TryParse(form["Number2"], out int number2);

            Number1 = number1;
            Number2 = number2;
            if (r1 && r2)
            {
                Result = number1 + number2;
            }
            else
            {
                // problem...
            }

        }
        //public void OnPost() 
        //{
        //    var form = Request.Form;
        //    bool r1= int.TryParse(form["Number1"], out int number1);
        //    bool r2 = int.TryParse(form["Number2"], out int number2);

        //    if (r1 && r2) 
        //    {
        //        Result = number1 + number2;
        //    }
        //    else
        //    {
        //        // problem...
        //    }
        //}    
    }
}
