using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.BusinessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.EntityFramework;
using WebProgramlamaOdev.EntityLayer.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSession(options =>
{
    options.Cookie.Name = "MySessionCookie";
    options.IdleTimeout = TimeSpan.FromMinutes(10); // Oturumun süresini ayarlayabilirsiniz
    options.Cookie.IsEssential = true;
});

builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IDepartmentDal, EfDepartmentDal>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IHomeDal, EfHomeDal>();
builder.Services.AddScoped<IHomeService, HomeManager>();

builder.Services.AddScoped<IAdminDal, EfAdminDal>();
builder.Services.AddScoped<IAdminService, AdminManager>();

builder.Services.AddScoped<IAnaBilimDaliDal, EfAnaBilimDaliDal>();
builder.Services.AddScoped<IAnaBilimDaliService, AnaBilimDaliManager>();

builder.Services.AddScoped<IDoktorDal, EfDoktorDal>();
builder.Services.AddScoped<IDoktorService, DoktorManager>();

builder.Services.AddScoped<IHastaDal, EfHastaDal>();
builder.Services.AddScoped<IHastaService, HastaManager>();

builder.Services.AddScoped<IRandevuDal, EfRandevuDal>();
builder.Services.AddScoped<IRandevuService, RandevuManager>();

builder.Services.AddScoped<IPoliklinikDal, EfPoliklinikDal>();
builder.Services.AddScoped<IPoliklinikService, PoliklinikManager>();



builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

builder.Services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
builder.Services.AddMvc().
    AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).
    AddDataAnnotationsLocalization();

builder.Services.AddDbContext<Context>();
//builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequireDigit = false; // Rakam gerekliliði
    options.Password.RequireLowercase = false; // Küçük harf gerekliliði
    options.Password.RequireUppercase = false; // Büyük harf gerekliliði
    options.Password.RequireNonAlphanumeric = false; // Özel karakter gerekliliði
    options.Password.RequiredLength = 2; // Minimum þifre uzunluðu
})
    .AddEntityFrameworkStores<Context>();

builder.Services.AddControllers(
                options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

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

app.UseSession();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();
var supportedCultures = new[] { "en", "tr" };
var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[1]).AddSupportedCultures
    (supportedCultures).AddSupportedUICultures(supportedCultures);
app.UseRequestLocalization(localizationOptions);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
