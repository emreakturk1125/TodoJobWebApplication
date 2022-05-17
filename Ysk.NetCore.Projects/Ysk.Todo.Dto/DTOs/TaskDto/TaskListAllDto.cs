using System;
using System.Collections.Generic; 
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Dto.DTOs.TaskDto
{
    public class TaskListAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Urgency Urgency { get; set; }
        public AppUser AppUser { get; set; }
        public List<Report> Reports { get; set; }
    }
}
