using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentlerAdmin.Repositories.Common;

namespace RentlerAdmin.Repositories.EntityFramework.Configuration.Ninject
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            // Also load DbContext in ThreadScope
            Kernel.Bind<IUserRepository>().To<UserRepository>().InThreadScope();
        }
    }
}
