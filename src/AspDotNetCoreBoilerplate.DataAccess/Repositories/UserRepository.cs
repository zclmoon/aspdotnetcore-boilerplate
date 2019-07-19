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
            var sql = @"SELECT * FROM my_test.user_info LIMIT 0, 10;"; ;


            using (var conn = new MySqlConnection(_connString))
            {
                var result = await conn.QueryAsync<UserEntity>(sql);

                return result.ToList();
            }
        }

        public async Task CreateUserAsync(UserEntity userEntity)
        {

            using (var conn = new MySqlConnection(_connString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    // Sample: this is for building a insert sql string in a pretty way.
                    StringBuilder sql = new StringBuilder();

                    var param = new DynamicParameters();

                    sql.Append(CreateInsertUserSql(userEntity, param));

                    sql.Append("SELECT @MediaId");


                    conn.QueryFirstOrDefault<int>(sql.ToString(), param, transaction);

                    transaction.Commit();
                }

            }
        }

        private string CreateInsertUserSql(UserEntity userEntity, DynamicParameters param)
        {
            var sql = @"


";
            param.Add("", "");
            param.Add("","");

            return sql;
        }


    } // UserRepository
}
