using blog_app_test.Models;

namespace blog_app_test.ViewModels
{
    public class BlogEntryListViewModel
    {
        public IEnumerable<BlogEntry> Items { get; set; }

        public BlogEntryListViewModel(IEnumerable<BlogEntry> items)
        {
            Items = items;
        }
    }
}
