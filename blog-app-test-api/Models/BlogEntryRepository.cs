using Microsoft.EntityFrameworkCore;

namespace blog_app_test_api.Models
{
    public class BlogEntryRepository : IBlogEntryRepository
    {
        private readonly BlogAppTestDbContext dbContext;

        public BlogEntryRepository(BlogAppTestDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public int Create(BlogEntry entry)
        {
            entry.Created = DateTime.Now;

            dbContext.Add(entry);

            dbContext.SaveChanges();

            return entry.BlogEntryId;
        }

        public BlogEntry? Get(int id)
        {
            return dbContext.BlogEntries.FirstOrDefault(e => e.BlogEntryId == id);
        }

        public IEnumerable<BlogEntry> GetAll()
        {
            return dbContext.BlogEntries;
        }

        public IEnumerable<BlogEntry> Search(string searchKeyWord)
        {
            var result = dbContext.BlogEntries.Where(p => p.Title.Contains(searchKeyWord) || p.Author.Contains(searchKeyWord) || p.Content.Contains(searchKeyWord));
            return result;
        }
    }
}

