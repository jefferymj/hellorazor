using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Your message goes here!";
            string[] people = {"Jeff", "John", "Jane", "Jill"};
            ViewData["People"] = people;

        }
    }
}
