using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Classrooms.Pages
{
    public class ClassroomsModel : PageModel
    {
        public Classroom Lamarr = new(1, "Lamarr");
        public Classroom Kendrick = new(2, "Kendrick");
        public Classroom Giertz = new(3, "Giertz");

        public void OnGet()
        {
        }
    }
}
