using DevConnect.Contexts;      // ✔ IMPORTANTE: usar o namespace do seu contexto
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✔ REGISTRAR O CONTEXTO AQUI
builder.Services.AddDbContext<DevConnectContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DevCon_Windows")
    )
);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();

