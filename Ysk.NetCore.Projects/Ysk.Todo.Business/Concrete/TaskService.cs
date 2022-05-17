using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Concrete
{
    public class TaskService : ITaskService
    {
        private readonly ITaskDal _taskDal;
        public TaskService(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public void Delete(Task item)
        {
            _taskDal.Delete(item);
        }
        public List<Task> GetAll()
        {
            return _taskDal.GetAll();
        }
        public List<Task> GetAllByAppUserId(int appUserId)
        {
            return _taskDal.GetAllByAppUserId(appUserId);
        }
        public List<Task> GetAllTaskWithUncompleted()
        {
            return _taskDal.GetAllTaskWithUncompleted();
        }
        public List<Task> GetAllWithAllTable(Expression<Func<Task, bool>> filter)
        {
            return _taskDal.GetAllWithAllTable(filter);
        }
        public List<Task> GetAllWithAllTableAndUncompleted(out int totalPage, int userId, int activePage)
        {
            return _taskDal.GetAllWithAllTableAndUncompleted(out totalPage, userId, activePage);
        }
        public Task GetById(int id)
        {
            return _taskDal.GetById(id);
        }

        public int GetCompletedTask()
        {
            return _taskDal.GetCompletedTask();
        }

        public int GetCompletedTaskByAppUserId(int id)
        {
            return _taskDal.GetCompletedTaskByAppUserId(id);
        }

        public int GetPendingAssignmentTask()
        {
            return _taskDal.GetPendingAssignmentTask();
        }

        public Task GetReportsById(int id)
        {
            return _taskDal.GetReportsById(id);
        }

        public int GetRequiredCompleteTaskByAppUserId(int id)
        {
            return _taskDal.GetRequiredCompleteTaskByAppUserId(id);
        }

        public Task GetUrgencyById(int id)
        {
            return _taskDal.GetUrgencyById(id);
        }
        public void Save(Task item)
        {
            _taskDal.Save(item);
        }
        public void Update(Task item)
        {
            _taskDal.Update(item);
        }
    }
}
