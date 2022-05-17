using Microsoft.AspNetCore.Identity; 
using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; } = "default.png";  // Herhangibir resim seçilmemiş ise default.png yi kaydet
        public List<Task> Tasks { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
