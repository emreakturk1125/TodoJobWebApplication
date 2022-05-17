using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        List<Notification> GetAllUnRead(int appUserId);
        int GetUnreadCountByAppuserId(int appUserId);
    }
}
