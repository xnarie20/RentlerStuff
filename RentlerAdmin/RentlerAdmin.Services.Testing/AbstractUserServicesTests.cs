using Ninject;
using RentlerAdmin.Services.Common;

namespace RentlerAdmin.Services.Testing
{
    public abstract class AbstractUserServicesTests : AbstractTest
    {
        public IUsersService UsersService { get; private set; }

        protected AbstractUserServicesTests()
        {
            UsersService = Kernel.Get<IUsersService>();
        }
    }
}