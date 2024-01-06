using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetInsta.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PetInstaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PetInstaContext") ?? throw new InvalidOperationException("Connection string 'PetInstaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Posts}/{action=Index}/{id?}");

app.Run();
