using AspDotNetCoreBoilerplate.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetCoreBoilerplate.Domain.User
{
    public static class UserExtension
    {
        public static User ToUser(this UserEntity userEntity)
        {
            if (userEntity == null)
            {
                return null;
            }

            return new User()
            {
                UserId = userEntity.Id,
                MobilePhone = userEntity.MobilePhone,
                Address = userEntity.Address,
                Birthday = userEntity.Birthday,
                Email = userEntity.Email,
                Gender = userEntity.Gender,
                UserName = userEntity.Name
            };
        }
    }
}
