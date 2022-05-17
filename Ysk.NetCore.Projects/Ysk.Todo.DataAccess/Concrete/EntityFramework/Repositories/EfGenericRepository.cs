using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ysk.Todo.DataAccess.Abstract;
using Ysk.Todo.DataAccess.Concrete.EntityFramework.Context;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        
        public void Delete(T item)
        {
            using var context = new TodoContext();
            context.Set<T>().Remove(item);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new TodoContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new TodoContext();
            return context.Set<T>().Find(id);
        }

        public void Save(T item)
        {
            using var context = new TodoContext();
            context.Set<T>().Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            using var context = new TodoContext();
            context.Set<T>().Update(item);
            context.SaveChanges();
        }
    }
}
