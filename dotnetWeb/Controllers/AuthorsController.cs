using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class AuthorsController : Controller
    {
        // GET: AuthorsController
        public ActionResult Index()
        {
            return View();
        }

    }
}
