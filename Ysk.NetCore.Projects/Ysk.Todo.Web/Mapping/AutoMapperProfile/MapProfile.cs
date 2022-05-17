using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Dto.DTOs.NotificationDto;
using Ysk.Todo.Dto.DTOs.ReportDto;
using Ysk.Todo.Dto.DTOs.TaskDto;
using Ysk.Todo.Dto.DTOs.UrgencyDto;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Web.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UrgencyAddDto, Urgency>();
            CreateMap<Urgency, UrgencyAddDto>();

            CreateMap<UrgencyListDto, Urgency>();
            CreateMap<Urgency, UrgencyListDto>();

            CreateMap<UrgencyUpdateDto, Urgency>();
            CreateMap<Urgency, UrgencyUpdateDto>();

            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();

            CreateMap<AppUserListDto, AppUser>();
            CreateMap<AppUser, AppUserListDto>();

            CreateMap<AppUserSignInDto, AppUser>();
            CreateMap<AppUser, AppUserSignInDto>();

            CreateMap<NotificationListDto, Notification>();
            CreateMap<Notification, NotificationListDto>();

            CreateMap<TaskAddDto, Entities.Concrete.Task>();
            CreateMap<Entities.Concrete.Task, TaskAddDto>();

            CreateMap<TaskUpdateDto, Entities.Concrete.Task>();
            CreateMap<Entities.Concrete.Task, TaskUpdateDto>();

            CreateMap<TaskListDto, Entities.Concrete.Task>();
            CreateMap<Entities.Concrete.Task, TaskListDto>();

            CreateMap<TaskListAllDto, Entities.Concrete.Task>();
            CreateMap<Entities.Concrete.Task, TaskListAllDto>();

            CreateMap<ReportAddDto, Report>();
            CreateMap<Report, ReportAddDto>();

            CreateMap<ReportUpdateDto, Report>();
            CreateMap<Report, ReportUpdateDto>();

            CreateMap<ReportFileDto, Report>();
            CreateMap<Report, ReportFileDto>();
        }
    }
}
