using Microsoft.AspNetCore.Mvc;
using SimpleBlog_Test.Models.Domain;
using SimpleBlog_Test.Models.ViewModels;

namespace SimpleBlog_Test.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Posts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(NewPostNewModel model)
        {
            Post post = new Post
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                Author = model.Author,
                ShortDescription = model.ShortDescription,
                CreatedPost = DateTime.Now,
                UpdatedPost = DateTime.Now,
                IsVisiable = model.IsVisiable
            };
            StaticData.AddPost(post);
            return RedirectToAction("Index", "Post");
        }
    }
}
