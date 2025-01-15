using Microsoft.AspNetCore.Mvc;

namespace TestDBconection.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
