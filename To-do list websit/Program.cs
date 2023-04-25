
using To_do_list_websit.models;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<context>();
builder.Services.AddSession(o =>
{
    o.IdleTimeout = TimeSpan.FromMinutes(10);
    o.Cookie.IsEssential = true;
    o.Cookie.HttpOnly = true;
});
var app = builder.Build();
app.MapControllerRoute("default", "{controller=tasks}/{action=index}");
app.Run();
