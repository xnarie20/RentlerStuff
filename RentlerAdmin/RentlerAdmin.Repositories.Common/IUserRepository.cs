using NexBusiness.Repositories.Common;
using RentlerAdmin.Data.Core;

namespace RentlerAdmin.Repositories.Common
{
    public interface IUserRepository : IRepository<User>
    {
        User Authenticate(string email, string passowrd);
    }
}
