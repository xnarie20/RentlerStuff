using RentlerAdmin.Data.Core;
using RentlerAdmin.Repositories.Common;
using RentlerAdmin.Services.Common;

namespace RentlerAdmin.Services.Core
{
    public class UsersService : IUsersService
    {
        protected IUserRepository UserRepository { get; set; }

        public UsersService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public User Authenticate(string email, string password)
        {
            return UserRepository.Authenticate(email, password);
        }
    }
}
