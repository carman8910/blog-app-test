using blog_app_test.Models;

namespace blog_app_test.ApiClient
{
    public interface IBlogEntryRestService
    {
        Task<IEnumerable<BlogEntry>> GetAll();

        Task<BlogEntry> GetById(int id);

        Task Post(BlogEntry entry);

        Task<IEnumerable<BlogEntry>> Search(string keyword);
    }
}
