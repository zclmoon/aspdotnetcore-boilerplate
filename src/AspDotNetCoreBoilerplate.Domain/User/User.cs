using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetCoreBoilerplate.Domain.User
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
