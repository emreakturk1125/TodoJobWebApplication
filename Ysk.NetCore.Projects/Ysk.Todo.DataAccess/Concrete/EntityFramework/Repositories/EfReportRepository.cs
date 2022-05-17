
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfReportRepository : EfGenericRepository<Report>, IReportDal
    {
        public int GetReportCount()
        {
            using (var context = new TodoContext())
            { 
                return context.Reports.Count();
            }
        }
        public int GetReportCountByAppUserId(int id)
        {
            using (var context = new TodoContext())
            {
               var result = context.Tasks.Include(x => x.Reports).Where(x => x.AppUserId == id);
               return result.SelectMany(x => x.Reports).Count();
            }
        }

        public Report GetWithTaskById(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Reports.Include(x => x.Task).ThenInclude(x => x.Urgency).Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}
