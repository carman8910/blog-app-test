using blog_app_test_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog_app_test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogEntriesController : ControllerBase
    {
        private readonly IBlogEntryRepository blogEntryRepository;

        public BlogEntriesController(IBlogEntryRepository blogEntryRepository)
        {
            this.blogEntryRepository = blogEntryRepository ?? throw new ArgumentNullException(nameof(blogEntryRepository));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = blogEntryRepository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}", Name = nameof(GetEntryById))]
        public IActionResult GetEntryById(int id)
        {
            var result = blogEntryRepository.Get(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("search")]
        public IActionResult Search(string searchKeyWord)
        {
            var result = blogEntryRepository.Search(searchKeyWord);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(BlogEntry entry)
        {
            blogEntryRepository.Create(entry);

            return Ok();
        }
    }
}