using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfNotificationRepository : EfGenericRepository<Notification>, INotificationDal
    {
        public List<Notification> GetAllUnRead(int appUserId)
        {
            using (var context = new  TodoContext())
            {
                return context.Notifications.Where(x => x.AppUserId == appUserId && !x.State).ToList();
            }
        }

        public int GetUnreadCountByAppuserId(int appUserId)
        {
            using (var context = new TodoContext())
            {
                return context.Notifications.Count(x => x.AppUserId == appUserId && !x.State);
            }
        }
    }
}
