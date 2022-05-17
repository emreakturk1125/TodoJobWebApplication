using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Abstract
{
    public interface ITaskDal : IGenericDal<Task>
    {
        List<Task> GetAllTaskWithUncompleted();
        List<Task> GetAllWithAllTable(Expression<Func<Task,bool>> filter);
        Task GetUrgencyById(int id);
        List<Task> GetAllByAppUserId(int appUserId);
        Task GetReportsById(int id);
        List<Task> GetAllWithAllTableAndUncompleted(out int totalPage, int userId, int activePage);
        int GetCompletedTaskByAppUserId(int id);
        int GetRequiredCompleteTaskByAppUserId(int id);
        int GetPendingAssignmentTask();
        int GetCompletedTask();

    }
}
