using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentlerAdmin.Services.Testing
{
    [TestClass]
    public class UsersServiceTests : AbstractUserServicesTests
    {
        [TestMethod]
        public void Authenticate_Valid_User()
        {
            var email = "test@test.com";
            var password = "Password2012";

            var user = UsersService.Authenticate(email, password);

            Assert.IsNotNull(user);

        }
    }

}
