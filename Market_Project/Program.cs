using BusinessLogic;
using BusinessLogic.Interfaces;
using data_access.Data;
using Microsoft.EntityFrameworkCore;
using Market_Project.Services;
using Microsoft.AspNetCore.Identity;

namespace Market_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connStr = builder.Configuration.GetConnectionString("LocalDb");

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext(connStr);

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MarketDbContext>();


            builder.Services.AddAutoMapper();
            builder.Services.AddFluentValidators();

            builder.Services.AddCustomServices();
            builder.Services.AddScoped<IFavoriteService, FavoriteService>();

            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();
                
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}