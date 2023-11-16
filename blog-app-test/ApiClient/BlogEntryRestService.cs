using blog_app_test.Models;

namespace blog_app_test.ApiClient
{
    public class BlogEntryRestService : IBlogEntryRestService
    {
        private readonly ApiSettings apiSettings;
        private readonly HttpClient httpClient;

        public BlogEntryRestService(ApiSettings apiSettings)
        {
            this.apiSettings = apiSettings ?? throw new ArgumentNullException(nameof(apiSettings));
            var handler = new HttpClientHandler();
            httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(apiSettings.BasePath)
            };
        }

        public async Task<IEnumerable<BlogEntry>> GetAll()
        {
            HttpResponseMessage response = httpClient.GetAsync(apiSettings.ResourcePaths.BlogEntries).Result;
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<IEnumerable<BlogEntry>>();
            return result ?? new List<BlogEntry>();
        }

        public async Task<BlogEntry> GetById(int id)
        {
            HttpResponseMessage response = httpClient.GetAsync($"{apiSettings.ResourcePaths.BlogEntries}/{id}").Result;
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<BlogEntry>();
            return result ?? new BlogEntry();
        }

        public async Task Post(BlogEntry entry)
        {
            HttpResponseMessage response  = await httpClient.PostAsJsonAsync<BlogEntry>(apiSettings.ResourcePaths.BlogEntries, entry);
            response.EnsureSuccessStatusCode();
        }

        public async Task<IEnumerable<BlogEntry>> Search(string keyword)
        {
            HttpResponseMessage response = httpClient.GetAsync($"{apiSettings.ResourcePaths.BlogEntries}/search?searchKeyWord={keyword}").Result;
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<IEnumerable<BlogEntry>>();
            return result ?? new List<BlogEntry>();
        }
    }
}
