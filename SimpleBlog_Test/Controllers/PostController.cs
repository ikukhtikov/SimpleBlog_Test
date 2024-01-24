using Microsoft.AspNetCore.Mvc;
using SimpleBlog_Test.Models.ViewModels;

namespace SimpleBlog_Test.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var posts = StaticData.Posts.Select(post => new PostViewModel
            {
                ShortDescription = post.ShortDescription,
                Name = post.Name,
                Author = post.Author
            }).ToList();
            return View(posts);
        }

        public IActionResult Post()
        {
            return View();
        }
    }
}
