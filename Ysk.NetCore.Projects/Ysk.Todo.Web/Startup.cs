using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ysk.Todo.Business.DIContainer;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.CustomCollectionExtensions;
using Ysk.Todo.Web.Identity;

namespace Ysk.Todo.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            // service ayarı
            services.AddCustomContainerWithDependencies();

            services.AddDbContext<TodoContext>();

            // Identity & Cookie ayarları
            services.AddCustomIdentity();

            // AutoMapper ayarı 
            services.AddAutoMapper(typeof(Startup));

            // Validation ayarı
            services.AddCustomValidator();

            // FluentValidation ayarı
            services.AddControllersWithViews().AddFluentValidation();
        }
         
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                // (Development) hatayı sayfaya basar
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // (Production) Hata durumunda gösterilecek hata sayfası
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            // Hata sayfası ayarı, useRouting'den önce olmalıdır
            app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");

            app.UseRouting();

            app.UseAuthentication();  

            app.UseAuthorization();

            IdentityInitializer.SeedData(userManager, roleManager).Wait();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Area için routing ayarı
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                    );
                // Uygulama için routing ayarı
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
