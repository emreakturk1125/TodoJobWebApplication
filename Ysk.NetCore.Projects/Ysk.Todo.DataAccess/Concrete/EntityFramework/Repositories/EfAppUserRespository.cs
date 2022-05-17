using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Entities.Helper;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfAppUserRespository : IAppUserDal
    {
        // Not : Identity tabloları arasında eager loading yapılamyor bu yüzden alttaki gibi sorgu yaptık
        public List<AppUser> GetAllWithoutAdmin()
        {
            List<AppUser> result;
            using (var context = new TodoContext())
            {

                #region 1. Yöntem

                //Select * from AspNetUsers 
                //    inner join AspNetUserRoles on AspNetUsers.Id = AspNetUserRoles.UserId
                //    inner join AspNetRoles on AspNetUserRoles.RoleId = AspNetRoles.Id 
                //          where AspNetRoles.Name = 'Name'; 
                #endregion

                #region 2. Yöntem

                //var result1 = context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
                //{
                //    user = resultUser,
                //    userRole = resultUserRole
                //}).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId,role => role.Id,(resultTable,resultRole) => new { 
                //    user = resultTable.user,
                //    userRoles = resultTable.userRole,
                //    roles = resultRole
                //}).Where(x => x.roles.Name == "Member").Select(x => new AppUser() {

                //    Id = x.user.Id,
                //    Name = x.user.Name,
                //    Surname = x.user.Surname,
                //    Picture = x.user.Picture,
                //    Email = x.user.Email,
                //    UserName = x.user.UserName

                //}); 
                #endregion

                //3. Yöntem

                result = (from user in context.Users
                          join userRole in context.UserRoles on user.Id equals userRole.UserId
                          join role in context.Roles on userRole.RoleId equals role.Id
                          where role.Name == "Member"
                          select new AppUser()
                          {
                              Id = user.Id,
                              Name = user.Name,
                              Surname = user.Surname,
                              Picture = user.Picture,
                              Email = user.Email,
                              UserName = user.UserName

                          }).ToList();

            }

            return result;
        }
        public List<AppUser> GetAllWithoutAdmin(out int totalPage, string searchWord, int activePage = 1)
        {
            using (var context = new TodoContext())
            {
                var result = (from user in context.Users
                              join userRole in context.UserRoles on user.Id equals userRole.UserId
                              join role in context.Roles on userRole.RoleId equals role.Id
                              where role.Name == "Member"
                              select new AppUser()
                              {
                                  Id = user.Id,
                                  Name = user.Name,
                                  Surname = user.Surname,
                                  Picture = user.Picture,
                                  Email = user.Email,
                                  UserName = user.UserName

                              });

                totalPage = (int)Math.Ceiling((double)result.Count() / 3);

                if (!String.IsNullOrEmpty(searchWord))
                {
                    result = result.Where(x => x.Name.ToLower().Contains(searchWord.ToLower()) || x.Surname.ToLower().Contains(searchWord.ToLower()));
                    totalPage = (int)Math.Ceiling((double)result.Count() / 3);
                }

                result = result.Skip((activePage - 1) * 3).Take(3);

                return result.ToList();
            }

        }

        public List<DualHelper> GetMostTaskCompletedPersonel()
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Include(x => x.AppUser)
                    .Where(x => x.Status)
                    .GroupBy(x => x.AppUser.UserName).
                    OrderByDescending(x => x.Count()).Take(5)
                    .Select(x => new DualHelper
                    {
                        Name = x.Key,
                        TaskCount = x.Count()
                    }).ToList();
            }
        }

        public List<DualHelper> GetMostEmployedOnTask()
        {
            using (var context = new TodoContext())
            {
                return context.Tasks.Include(x => x.AppUser)
                    .Where(x => !x.Status && x.AppUserId != null)
                    .GroupBy(x => x.AppUser.UserName).
                    OrderByDescending(x => x.Count())
                    .Select(x => new DualHelper
                    {
                        Name = x.Key,
                        TaskCount = x.Count()
                    }).ToList();
            }
        }
    }
}
