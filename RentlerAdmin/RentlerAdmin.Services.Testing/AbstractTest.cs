using Ninject;
using Ninject.Modules;
using RentlerAdmin.Repositories.Testing.Configuration.Ninject;
using RentlerAdmin.Services.Core.Configuration.Ninject;

namespace RentlerAdmin.Services.Testing
{
    public abstract class AbstractTest
    {
        public IKernel Kernel { get; private set; }

        protected AbstractTest()
        {
            Kernel = new StandardKernel(new FakeRepositoryNinjectModule(), new CoreServicesNinjectModule());
        }
    }
}