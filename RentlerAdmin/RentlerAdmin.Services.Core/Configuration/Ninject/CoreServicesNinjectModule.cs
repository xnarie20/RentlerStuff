using Ninject.Modules;
using RentlerAdmin.Repositories.Common;
using RentlerAdmin.Services.Common;

namespace RentlerAdmin.Services.Core.Configuration.Ninject
{
    public class CoreServicesNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IUsersService>().To<UsersService>();
        }
    }
}
