using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Entities.Helper;

namespace Ysk.Todo.DataAccess.Abstract
{
    public interface IAppUserDal  
    {
        List<AppUser> GetAllWithoutAdmin();
        List<AppUser> GetAllWithoutAdmin(out int totalPage, string searchWord, int activePage = 1);
        List<DualHelper> GetMostTaskCompletedPersonel();
        List<DualHelper> GetMostEmployedOnTask();
    }
}
