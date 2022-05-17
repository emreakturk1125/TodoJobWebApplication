using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Web.Areas.Admin.Models
{
    public class TaskListViewModel
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
