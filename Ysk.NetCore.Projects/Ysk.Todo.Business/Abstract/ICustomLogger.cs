using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.Business.Abstract
{
    public interface ICustomLogger
    {
        public void LogError(string message);        
    }
}
