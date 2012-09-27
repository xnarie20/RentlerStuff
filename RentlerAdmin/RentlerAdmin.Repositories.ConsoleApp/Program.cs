using Ninject;
using RentlerAdmin.Repositories.EntityFramework.Configuration.Ninject;

namespace RentlerAdmin.Repositories.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new RepositoryNinjectModule());
        }
    }
}
