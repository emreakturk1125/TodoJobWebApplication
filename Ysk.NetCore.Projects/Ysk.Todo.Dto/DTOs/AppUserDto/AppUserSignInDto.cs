using System;
using System.Collections.Generic;
using System.Text;

namespace Ysk.Todo.Dto.DTOs.AppUserDto
{
    public class AppUserSignInDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
