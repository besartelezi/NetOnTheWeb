using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOntheWeb.Models;

namespace Students.pages
{
    public class StudentsModel : PageModel
    {
        public Student Besart = new(1, "Besart", 1);
        public Student Mo = new(2,"Mo", 1);
        public Student Pablo = new(3,"Pablo", 2);
        public Student Lucas = new(4,"Lucas", 3);
        public Student Shiva = new(5, "Shiva", 2);
        public Student Zeno = new(6, "Zeno", 3);

        public void OnGet()
        {
        }
    }
}
