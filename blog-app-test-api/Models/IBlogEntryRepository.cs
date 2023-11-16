namespace blog_app_test_api.Models
{
    public interface IBlogEntryRepository
    {
        IEnumerable<BlogEntry> GetAll();

        IEnumerable<BlogEntry> Search(string searchKeyWord);

        BlogEntry? Get(int id);

        int Create(BlogEntry entry);
    }
}
