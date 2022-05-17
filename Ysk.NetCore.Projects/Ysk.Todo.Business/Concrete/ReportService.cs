using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.Business.Concrete
{
    public class ReportService : IReportService
    {
        private readonly IReportDal _reportDal;

        public ReportService(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public void Delete(Report item)
        {
            _reportDal.Delete(item);
        }

        public List<Report> GetAll()
        {
            return _reportDal.GetAll();
        }

        public Report GetById(int id)
        {
            return _reportDal.GetById(id);
        }

        public int GetReportCount()
        {
            return _reportDal.GetReportCount();
        }
        public int GetReportCountByAppUserId(int id)
        {
            return _reportDal.GetReportCountByAppUserId(id);
        }

        public Report GetWithTaskById(int id)
        {
            return _reportDal.GetWithTaskById(id);
        }
        public void Save(Report item)
        {
            _reportDal.Save(item);
        }
        public void Update(Report item)
        {
            _reportDal.Update(item);
        }
    }
}
