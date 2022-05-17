using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Abstract
{
    public interface ITaskService : IGenericService<Task>
    {
        List<Task> GetAllTaskWithUncompleted();
        List<Task> GetAllWithAllTable(Expression<Func<Task, bool>> filter);
        Task GetUrgencyById(int id);
        List<Task> GetAllByAppUserId(int appUserId);
        Task GetReportsById(int id);
        List<Task> GetAllWithAllTableAndUncompleted(out int totalPage, int userId, int activePage=1);
        int GetCompletedTaskByAppUserId(int id);
        int GetRequiredCompleteTaskByAppUserId(int id);
        int GetPendingAssignmentTask();
        int GetCompletedTask();
    }
}
