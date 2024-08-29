using Microsoft.AspNetCore.Mvc;

namespace App_Structure.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovies()
        {
            return View();
        }
        public string Index()
        {
            string text = $"Welcome People";
            return text;
        }
    }
}
