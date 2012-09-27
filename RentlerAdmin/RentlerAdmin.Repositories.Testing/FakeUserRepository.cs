using System;
using System.Collections.Generic;
using NexBusiness.Repositories.Testing;
using RentlerAdmin.Data.Core;
using RentlerAdmin.Repositories.Common;

namespace RentlerAdmin.Repositories.Testing
{
    public class FakeUserRepository : FakeRepository<User>, IUserRepository
    {
        public override IEnumerable<User> SetupFakeData()
        {
            return new List<User>()
                       {
                           new User() {Email = "test@test.com", FirstName = "TestFirstName", LastName = "TestLastName"}
                       };
        }

        public User Authenticate(string email, string passowrd)
        {
            throw new NotImplementedException();
        }
    }
}
