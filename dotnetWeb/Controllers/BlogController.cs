using dotnetWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnetWeb.Controllers;

public class BlogController(
    ILogger<BlogController> _logger,
    BlogyContext _context) : Controller
{
    // GET: List Blog Controller
    public ActionResult Index()
    {
        return View();
    }
    
    // GET: SingleBlog Page
    public ActionResult Single(string PostId)
    {
        var post = _context.Posts.FirstOrDefault(x => x.PostId == PostId);
        
        if (post == null)
        {
            return NotFound();
        }
        return View(post);
    }
}

