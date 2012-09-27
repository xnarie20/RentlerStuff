using RentlerAdmin.Data.Core;

namespace RentlerAdmin.Services.Common
{
    public interface IUsersService
    {
        User Authenticate(string email, string password);
    }
}
