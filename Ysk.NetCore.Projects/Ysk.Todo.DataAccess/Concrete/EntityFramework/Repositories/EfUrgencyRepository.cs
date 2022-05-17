using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUrgencyRepository : EfGenericRepository<Urgency>, IUrgencyDal
    {
    }
}
