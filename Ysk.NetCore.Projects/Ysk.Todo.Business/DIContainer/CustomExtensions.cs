using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Business.Concrete;
using Ysk.Todo.Business.CustomLogger;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories;

namespace Ysk.Todo.Business.DIContainer
{
    public static class CustomExtensions
    {
        public static void AddCustomContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IUrgencyService, UrgencyService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<INotificationService, NotificationService>();

            services.AddScoped<ITaskDal, EfTaskRepository>();
            services.AddScoped<IUrgencyDal, EfUrgencyRepository>();
            services.AddScoped<IReportDal, EfReportRepository>();
            services.AddScoped<IAppUserDal, EfAppUserRespository>();
            services.AddScoped<INotificationDal, EfNotificationRepository>();

            services.AddScoped<ICustomLogger, NLogLogger>();
        }
    }
}
