using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class CommentsController : Controller
    {
        // GET: CommentController
        public ActionResult Index()
        {
            return View();
        }

    }
}
