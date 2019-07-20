using AspDotNetCoreBoilerplate.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetCoreBoilerplate.Domain.User
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public GenderEnum? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
    }
}
