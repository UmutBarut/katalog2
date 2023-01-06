using Autofac.Extensions.DependencyInjection;
using Autofac;
using Katalog.Core.Utilities.IoC;
using Katalog.Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using Katalog.Business.Abstracts;
using Katalog.Business.Concrete;
using Katalog.Business.DependencyResolvers.Autofac;
using Katalog.Dataaccess.Concrete.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});


builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddIdentity<Kullanici , IdentityRole>(x => 
{
x.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/GirisYap";
    options.Cookie.Name = "auth_cookie";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    

});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "GirisYap",
      pattern: "GirisYap",
      defaults: new { controller = "Login", action = "Login" }
  );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
        name: "anasayfa",
        pattern: "anasayfa",
        defaults: new { controller = "Home", action = "Index" }
    );
    endpoints.MapControllerRoute(
        name: "hakkimizda",
        pattern: "hakkimizda",
        defaults: new { controller = "Home", action = "Hakkimizda" }
    );
    endpoints.MapControllerRoute(
       name: "admin/index",
       pattern: "admin/index",
       defaults: new { controller = "Admin", action = "Index" }
   );
    endpoints.MapControllerRoute(
       name: "uruntanimlama",
       pattern: "urutanimlama",
       defaults: new { controller = "Admin", action = "UrunTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "firmatanimlama",
       pattern: "firmatanimlama",
       defaults: new { controller = "Admin", action = "FirmaTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "markatanimlama",
       pattern: "markatanimlama",
       defaults: new { controller = "Admin", action = "MarkaTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "tiptanimlama",
       pattern: "tiptanimlama",
       defaults: new { controller = "Admin", action = "TipTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "modeltanimlama",
       pattern: "modeltanimlama",
       defaults: new { controller = "Admin", action = "ModelTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "oemtanimlama",
       pattern: "oemtanimlama",
       defaults: new { controller = "Admin", action = "OEMTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "referanstanimlama",
       pattern: "referanstanimlama",
       defaults: new { controller = "Admin", action = "ReferansTanimlama" }
   );
    endpoints.MapControllerRoute(
       name: "katalogliste",
       pattern: "katalogliste ",
       defaults: new { controller = "Katalog", action = "KatalogListe" }
   );
    endpoints.MapControllerRoute(
       name: "UrunDetay",
       pattern: "UrunDetay",
       defaults: new { controller = "Katalog", action = "UrunDetay" }
   );
   endpoints.MapControllerRoute(
       name: "edit",
       pattern: "admin/edit/{id?}",
       defaults: new { controller = "Admin", action = "Edit" }
   );
   



});

app.Run();
