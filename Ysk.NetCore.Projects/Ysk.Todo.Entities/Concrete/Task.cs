using System;
using System.Collections.Generic;
using Ysk.Todo.Entities.Abstract;

namespace Ysk.Todo.Entities.Concrete
{
    public class Task : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Oluşturulma tarihini default olarak bugün tarihi olarak kaydet
        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Report> Reports { get; set; }
    }
}
