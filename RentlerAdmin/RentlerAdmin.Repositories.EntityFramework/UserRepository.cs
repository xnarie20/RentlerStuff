using System;
using NexBusiness.Repositories.EntityFramework;
using RentlerAdmin.Data.Core;
using RentlerAdmin.Repositories.Common;

namespace RentlerAdmin.Repositories.EntityFramework
{
    public class UserRepository : Repository<User, Entities>, IUserRepository
    {
        public UserRepository(Entities dbContext)
            : base(dbContext)
        {
        }

        public User Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
