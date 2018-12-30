using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.Domain.User
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
