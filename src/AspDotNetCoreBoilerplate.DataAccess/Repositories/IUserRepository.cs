using AspDotNetCoreBoilerplate.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.DataAccess.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetUsersAsync();

        Task CreateUserAsync(UserEntity userEntity);
    }
}
