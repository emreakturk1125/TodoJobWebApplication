using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class,new()
    {
        void Save(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
        List<T> GetAll();
    }
}
