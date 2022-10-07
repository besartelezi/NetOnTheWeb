using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Teachers.Pages
{
    public class TeachersModel : PageModel
    {

        public Teacher Sicco = new(1, "Sicco", 1);
        public Teacher Tim = new(2, "Tim", 2);
        public Teacher Jordy = new(3, "Jordy", 3);


        public void OnGet()
        {
        }

    
    }
}
