using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfTaskRepository : EfGenericRepository<Task>, ITaskDal
    {
        public List<Task> GetAllByAppUserId(int appUserId)
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Where(x => x.AppUserId == appUserId).ToList();
            }
        }

        public List<Task> GetAllTaskWithUncompleted()
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.AsNoTracking().Include(x => x.Urgency).Where(x => !x.Status).OrderByDescending(x => x.CreatedDate).ToList();
            }
        }

        public List<Task> GetAllWithAllTable(Expression<Func<Task, bool>> filter)
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.AsNoTracking().Include(x => x.Urgency).Include(x => x.Reports).Include(x => x.AppUser).Where(filter).OrderByDescending(x => x.CreatedDate).ToList();
            }
        }

        public Task GetUrgencyById(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Include(x => x.Urgency).Include(x => x.AppUser).Where(x => !x.Status && x.Id == id).FirstOrDefault();
            }
        }
        public Task GetReportsById(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Include(x => x.Reports).Include(x => x.AppUser).Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public List<Task> GetAllWithAllTableAndUncompleted(out int totalPage, int userId, int activePage=1)
        {
            using (var context = new TodoContext())
            {
                var returnValue = context.Tasks.AsNoTracking().Include(x => x.Urgency).Include(x => x.Reports).Include(x => x.AppUser).Where(x => x.AppUserId == userId && x.Status).OrderByDescending(x => x.CreatedDate);
                totalPage = (int)Math.Ceiling((double)returnValue.Count() / 3);
                return returnValue.Skip((activePage - 1) * 3).Take(3).ToList();
            }
        }

        public int GetCompletedTaskByAppUserId(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Count(x => x.AppUserId == id && x.Status);
            }
        }

        public int GetRequiredCompleteTaskByAppUserId(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Count(x => x.AppUserId == id && !x.Status);
            }
        }

        public int GetPendingAssignmentTask()
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Count(x => x.AppUserId == null && !x.Status);
            }
        }

        public int GetCompletedTask()
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Count(x => x.Status);
            }
        }
    }
}
