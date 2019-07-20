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
                Birthday = userEntity.Birthday?? null,
                Email = userEntity.Email,
                Gender = userEntity.Gender,
                UserName = userEntity.Name
            };
        }

        public static UserEntity ToUserEntity(this User user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserEntity()
            {
                 Address = user.Address,
                 Birthday = user.Birthday,
                 Name = user.UserName,
                 Email = user.Email,
                 Gender = user.Gender,
                 MobilePhone = user.MobilePhone,   
                 CreatedBy = "1",
                 CreatedDateUtc = DateTime.UtcNow,
                 DeletedBy = null,
                 DeletedDateUtc = null,
                 Password = null,
                 UpdatedBy = null,
                 UpdatedDateUtc = null
            };
        }
    } // UserExtension
}
