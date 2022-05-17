using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Abstract
{
    public interface IReportDal : IGenericDal<Report>
    {
        Report GetWithTaskById(int id);
        int GetReportCountByAppUserId(int id);
        int GetReportCount();
    }
}
