using Microsoft.AspNetCore.Mvc;

namespace dotnetWeb.Controllers;

public class BlogController(ILogger<BlogController> _logger) : Controller
{
    // GET: BlogController
    public ActionResult Index()
    {
        return View();
    }
}

