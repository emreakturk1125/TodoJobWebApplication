using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Entities.Helper;

namespace Ysk.Todo.Business.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserDal _userDal;

        public AppUserService(IAppUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<AppUser> GetAllWithoutAdmin()
        {
            return _userDal.GetAllWithoutAdmin();
        }

        public List<AppUser> GetAllWithoutAdmin(out int totalPage, string searchWord, int activePage = 1)
        { 
            return _userDal.GetAllWithoutAdmin(out totalPage,searchWord, activePage);
        }

        public List<DualHelper> GetMostEmployedOnTask()
        {
            return _userDal.GetMostEmployedOnTask();
        }

        public List<DualHelper> GetMostTaskCompletedPersonel()
        {
            return _userDal.GetMostTaskCompletedPersonel();
        }
    }
}
