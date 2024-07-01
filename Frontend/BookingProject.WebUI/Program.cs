using BookingProject.WebUI.Mapping;
using BookingProject.DataAccessLayer.Concrete;
using BookingProject.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
