using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        List<Notification> GetAllUnRead(int appUserId);
        int GetUnreadCountByAppuserId(int appUserId);
    }
}
