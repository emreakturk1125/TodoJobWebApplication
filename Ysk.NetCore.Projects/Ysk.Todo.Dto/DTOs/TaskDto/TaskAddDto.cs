using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.Dto.DTOs.TaskDto
{
    public class TaskAddDto
    { 
        public string Name { get; set; }
        public string Description { get; set; } 
        public int UrgencyId { get; set; }
    }
}
