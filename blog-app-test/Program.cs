using blog_app_test.ApiClient;

var builder = WebApplication.CreateBuilder(args);


var apiSettings = new ApiSettings();
builder.Configuration.GetSection("api").Bind(apiSettings);

builder.Services.AddSingleton<ApiSettings>(apiSettings);
builder.Services.AddScoped<IBlogEntryRestService, BlogEntryRestService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllerRoute(name: "default", pattern: "{controller=BlogEntry}/{action=List}/{id?}");

app.Run();
