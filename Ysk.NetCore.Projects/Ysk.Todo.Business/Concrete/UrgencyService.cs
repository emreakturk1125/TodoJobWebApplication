using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Concrete
{
    public class UrgencyService : IUrgencyService
    {
        private readonly IUrgencyDal _urgencyDal;

        public UrgencyService(IUrgencyDal urgencyDal)
        {
            _urgencyDal = urgencyDal;
        }

        public void Delete(Urgency item)
        {
            _urgencyDal.Delete(item);
        }

        public List<Urgency> GetAll()
        {
            return _urgencyDal.GetAll();
        }

        public Urgency GetById(int id)
        {
            return _urgencyDal.GetById(id);
        }

        public void Save(Urgency item)
        {
            _urgencyDal.Save(item);
        }

        public void Update(Urgency item)
        {
            _urgencyDal.Update(item);
        }
    }
}
