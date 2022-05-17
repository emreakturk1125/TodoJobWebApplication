using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Dto.DTOs.TaskDto
{
    public class TaskListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
    }
}
