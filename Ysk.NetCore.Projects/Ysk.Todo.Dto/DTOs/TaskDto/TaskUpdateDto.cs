using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.Dto.DTOs.TaskDto
{
    public class TaskUpdateDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; } 
        public int UrgencyId { get; set; }
    }
}
