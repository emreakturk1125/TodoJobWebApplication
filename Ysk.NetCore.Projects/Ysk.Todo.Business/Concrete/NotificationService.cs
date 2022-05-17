using System.Collections.Generic;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Concrete
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationDal _notificationDal;
        public NotificationService(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public void Delete(Notification item)
        {
            _notificationDal.Delete(item);
        }
        public List<Notification> GetAll()
        {
            return _notificationDal.GetAll();
        }

        public List<Notification> GetAllUnRead(int appUserId)
        {
            return _notificationDal.GetAllUnRead(appUserId);
        }

        public Notification GetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public int GetUnreadCountByAppuserId(int appUserId)
        {
            return _notificationDal.GetUnreadCountByAppuserId(appUserId);
        }

        public void Save(Notification item)
        {
            _notificationDal.Save(item);
        }
        public void Update(Notification item)
        {
            _notificationDal.Update(item);
        }
    }
}
