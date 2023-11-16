using blog_app_test.Models;
using blog_app_test.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using System.Text;
using System;
using System.Xml.Linq;
using blog_app_test.ApiClient;

namespace blog_app_test.Controllers
{
    public class BlogEntryController : Controller
    {
        private readonly IBlogEntryRestService blogEntryRestService;

        public BlogEntryController(IBlogEntryRestService blogEntryRestService)
        {
            this.blogEntryRestService = blogEntryRestService ?? throw new ArgumentNullException(nameof(blogEntryRestService));
        }

        public async Task<IActionResult> List()
        {
            var items = await blogEntryRestService.GetAll();
            return View(new BlogEntryListViewModel(items));
        }

        [HttpPost]
        public async Task<IActionResult> List(string searchKeyWord)
        {
            IEnumerable<BlogEntry> items;

            if (string.IsNullOrEmpty(searchKeyWord))
            {
                items = await blogEntryRestService.GetAll();
            } else
            {
                ViewBag.SearchKeyWord = searchKeyWord;
                items = await blogEntryRestService.Search(searchKeyWord);
            }

            return View(new BlogEntryListViewModel(items));
        }

        public IActionResult Publish()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Publish(BlogEntry blogEntry)
        {
            if (ModelState.IsValid)
            {
                await blogEntryRestService.Post(blogEntry);
                return RedirectToAction("PublishComplete");
            }

            return View(blogEntry);

        }

        public IActionResult PublishComplete()
        {
            return View();
        }
    }
}
