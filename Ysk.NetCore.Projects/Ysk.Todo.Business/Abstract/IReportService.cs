using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Abstract
{
    public interface IReportService : IGenericService<Report>
    {
        Report GetWithTaskById(int id);
        int GetReportCountByAppUserId(int id);
        int GetReportCount();
    }
}
