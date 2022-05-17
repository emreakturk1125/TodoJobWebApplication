using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Dto.DTOs.TaskDto;

namespace Ysk.Todo.Dto.DTOs.PersonalDto
{
    public class PersonalEntrustListDto
    {
        public AppUserListDto AppUser { get; set; }
        public TaskListDto Task { get; set; }
    }
}
