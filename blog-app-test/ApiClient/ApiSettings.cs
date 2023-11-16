namespace blog_app_test.ApiClient
{
    public class ApiSettings
    {
        public string BasePath { get; set; } = string.Empty;

        public ApiResourcePaths ResourcePaths { get; set; } = new ApiResourcePaths();

    }

    public class ApiResourcePaths
    {
        public string BlogEntries { get; set; } = string.Empty;
    }
}
