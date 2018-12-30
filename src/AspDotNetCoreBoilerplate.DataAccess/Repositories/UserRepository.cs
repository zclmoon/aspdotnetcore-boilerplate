using AspDotNetCoreBoilerplate.Configuration;
using AspDotNetCoreBoilerplate.DataAccess.Entities;
using Dapper;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
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
            var sql = @"select * from user_info";

            using (var conn = new MySqlConnection(_connString))
            {
                var result = await conn.QueryAsync<UserEntity>(sql);

                return result.ToList();
            }
        }
    }
}
