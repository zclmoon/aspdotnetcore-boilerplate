using AspDotNetCoreBoilerplate.Core;
using Dapper.Contrib.Extensions;
using System;

namespace AspDotNetCoreBoilerplate.DataAccess.Entities
{
    [Table("user_info")]
    public class UserEntity : EntityBase
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string MobilePhone { get; set; }

        /// <summary>
        ///  0 : femail
        ///  1 : mail
        ///  2: others
        /// </summary>
        public GenderEnum Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
