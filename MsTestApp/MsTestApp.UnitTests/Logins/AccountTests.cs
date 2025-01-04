using MsTestApp.Logins;
using MsTestApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestApp.UnitTests.Logins
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Validate_CorrectUserIdAndUserPassword_ReturnsTrue()
        {
            // Arrange
            int userId = 0;
            string userPassword = "mima";
            IUserRepository userRepo = new StubUserRepository();
            Account target = new Account(userRepo);

            // Act
            bool actual = target.Validate(userId, userPassword);

            // Assert
            Assert.IsTrue(actual);
        }
    }

    public class StubUserRepository : IUserRepository
    {
        public string GetPassword(int id)
        {
            return "mima";
        }
    }
}
