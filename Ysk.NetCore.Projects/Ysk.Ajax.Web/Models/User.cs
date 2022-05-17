using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ysk.Ajax.Web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public static class UserProcess
    {
        private static List<User> users = new List<User>()
        {
            new User{Id=1,Ad="User1"},
            new User{Id=2,Ad="User2"}
        };


        public static List<User> GetirHepsi()
        {
            return users;
        }

        public static User GetirIdile(int id)
        {
            return users.FirstOrDefault(I => I.Id == id);
        }

        public static void Ekle(User user)
        {
            users.Add(user);
        }

    }
}
