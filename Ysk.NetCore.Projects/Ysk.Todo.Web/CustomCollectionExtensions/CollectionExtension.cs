using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using Ysk.Todo.Business.ValidationRules.FluentValidation;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Dto.DTOs.ReportDto;
using Ysk.Todo.Dto.DTOs.TaskDto;
using Ysk.Todo.Dto.DTOs.UrgencyDto;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Web.CustomCollectionExtensions
{
    public static class CollectionExtension
    {
        public static void AddCustomIdentity(this IServiceCollection services)
        {
            // Identity ayarları
            services.AddIdentity<AppUser, AppRole>(opt => {
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<TodoContext>();

            // Cookie ayarları
            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "JobTrackingCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromDays(20);
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                opt.LoginPath = "/Home/Index";

            });
        }

        public static void AddCustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<UrgencyAddDto>, UrgencyAddValidator>();
            services.AddTransient<IValidator<UrgencyUpdateDto>, UrgencyUpdateValidator>();
            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddValidator>();
            services.AddTransient<IValidator<AppUserListDto>, AppUserListValidator>();
            services.AddTransient<IValidator<AppUserSignInDto>, AppUserSignInValidator>();
            services.AddTransient<IValidator<TaskAddDto>, TaskAddValidator>();
            services.AddTransient<IValidator<TaskUpdateDto>, TaskUpdateValidator>();
            services.AddTransient<IValidator<ReportAddDto>, ReportAddValidator>();
            services.AddTransient<IValidator<ReportUpdateDto>, ReportUpdateValidator>(); 
        }
    }
}
