using AspDotNetCoreBoilerplate.Configuration;
using AspDotNetCoreBoilerplate.DataAccess.Entities;
using Dapper;
using Dapper.Contrib;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connString;

        public UserRepository(IOptions<ConnectionStrings> options)
        {
            _connString = options.Value.ConnectionString;
        }

        public async Task<List<UserEntity>> GetUsersAsync()
        {
            var sql = @"SELECT * FROM my_test.user_info LIMIT 0, 10;";


            using (var conn = new MySqlConnection(_connString))
            {
                var result = await conn.QueryAsync<UserEntity>(sql);

                return result.ToList();
            }
        }

        public async Task<string> CreateUserAsync(UserEntity userEntity)
        {
            using (var conn = new MySqlConnection(_connString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    // this is for building a long sql string in many private methods.
                    StringBuilder sql = new StringBuilder();

                    var param = new DynamicParameters();

                    sql.Append(CreateInsertUserSql(userEntity, param));

                    await conn.QueryFirstOrDefaultAsync<int>(sql.ToString(), param, transaction);


                    transaction.Commit();
                }
            }

            return userEntity.Id;
        }

        private string CreateInsertUserSql(UserEntity userEntity, DynamicParameters param)
        {
            var sql = @"
DECLARE @UserId VARCHAR(100) = 0;

INSERT INTO `user_info`(
    `id`,`password`,`mobile_phone`,`gender`,`name`,`email`,`address`,`birthday`,
    `created_date_utc`,`created_by`,`updated_date_utc`,`updated_by`,`deleted_date_utc`,`deleted_by`)
VALUES (
    @id,
    @password,
    @mobilePhone,
    @gender,
    @name,
    @email,
    @address,
    @birthday,
    @createdDate,
    @createdBy,
    @updatedDate,
    @updatedBy,
    @deletedDate,
    @deletedBy);
";
            param.Add("id", userEntity.Id);
            param.Add("password", userEntity.Password);
            param.Add("mobilePhone", userEntity.MobilePhone);
            param.Add("gender", userEntity.Gender);
            param.Add("name", userEntity.Name);
            param.Add("email", userEntity.Email);
            param.Add("address", userEntity.Address);
            param.Add("birthday", userEntity.Birthday);
            param.Add("createdDate", userEntity.CreatedDateUtc);
            param.Add("createdBy", userEntity.CreatedBy);
            param.Add("updatedDate", userEntity.UpdatedDateUtc);
            param.Add("updatedBy", userEntity.UpdatedBy);
            param.Add("deletedDate", userEntity.DeletedDateUtc);
            param.Add("deletedBy", userEntity.DeletedBy);

            return sql;
        }


    } // UserRepository
}
