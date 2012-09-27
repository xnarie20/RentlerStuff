using Ninject.Modules;
using RentlerAdmin.Repositories.Common;

namespace RentlerAdmin.Repositories.Testing.Configuration.Ninject
{
    public class FakeRepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IUserRepository>().To<FakeUserRepository>().InSingletonScope();
        }
    }
}
