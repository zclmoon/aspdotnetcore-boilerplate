using AspDotNetCoreBoilerplate.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AspDotNetCoreBoilerplate.Domain.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var userEntities = await _userRepository.GetUsersAsync();

            return userEntities.Select(x => new User
            {
                UserId = x.Id,
                Email = x.Email,
                UserName = x.Name
            }).ToList();
        }
    }
}
