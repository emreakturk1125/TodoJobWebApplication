using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.Business.Abstract
{
    public interface IFileService
    {
        /// <summary>
        /// Geriye üretmiş ve upload etmiş olduğu pdf dosyasının virtual path'ini döner
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        string ToPdf<T>(List<T> list) where T : class, new(); 

        /// <summary>
        /// Geri Excel verisini byte dizisi olarak döner
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        byte[] ToExcel<T>(List<T> list) where T : class, new();
    }
}
