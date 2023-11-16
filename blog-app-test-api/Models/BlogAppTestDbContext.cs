using Microsoft.EntityFrameworkCore;

namespace blog_app_test_api.Models
{
    public class BlogAppTestDbContext : DbContext
    {
        public BlogAppTestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogEntry> BlogEntries { get; set; }
    }
}
