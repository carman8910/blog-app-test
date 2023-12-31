using blog_app_test_api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBlogEntryRepository,  BlogEntryRepository>();
builder.Services.AddControllers();
builder.Services.AddDbContext<BlogAppTestDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:BlogAppTestDbContextConnection"]);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

DbInitializer.Seed(app);

app.Run();
