using App.Data;
using App.Middlewares;
using App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRepository<Race>, EFRaceRepository>();

var connectionString = "server=localhost;user=root;password=my_password;database=app_db";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

builder.Services.AddDbContext<AppDbContext>(
  dbContextOptions => dbContextOptions
    .UseMySql(connectionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors()
);

builder.Services.AddAuthentication("CookieAuth")
.AddCookie("CookieAtuh", config => {
  config.Cookie.Name = "DriverCookie";
  config.LoginPath = "/Login";
  config.ExpireTimeSpan = TimeSpan.FromMinutes(5);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

// // My Own MiddleWare
// app.Use(async (context, next) =>
// {
//   // Sur l'aller
//   Console.WriteLine("... MW1 ===>");
//   await next();
//   // Sur le retour
//   Console.WriteLine("<=== MW1 ...");
// });

// // My Second MiddleWare
// app.Use(async (context, next) =>
// {
//   // Sur l'aller
//   Console.WriteLine("... MW2 ===>");
//   await next();
//   // Sur le retour
//   Console.WriteLine("<=== MW2 ...");
// });

//app.UseMiddleware<BasicMiddleware>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// app.MapControllerRoute(
//     name: "listRaces",
//     defaults: new { controller = "Races", action = "List" },
//     pattern: "Races"
// );

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints => {
  endpoints.MapControllers();
});

using (var scope = app.Services.CreateScope())
{
  scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();
  scope.ServiceProvider.GetRequiredService<AppDbContext>().Seed();
}

app.Run();
