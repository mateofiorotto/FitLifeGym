using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FitLifeGym.Data;
using FitLifeGym.Models; //use for seeder
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FitLifeGymContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FitLifeGymContext") ?? throw new InvalidOperationException("Connection string 'FitLifeGymContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//seeder
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//404
app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
