namespace blog_app_test_api.Models
{
    public class BlogEntry
    {
        public int BlogEntryId { get; set; }

        public string Title { get; set; } = string.Empty;

        // todo: Segregar información de autores en nueva entidad
        public string Author { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
