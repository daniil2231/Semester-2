using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void TestMethodLoginCustomer()
        {
            User user = new User();
            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user });
            LoginManager loginManager = new LoginManager(fakeAccRepo);

            Assert.AreEqual(user.Username, loginManager.Login("danito2231", "12341234").Username);
            Assert.AreEqual(user.Role, loginManager.Login("danito2231", "12341234").Role);
        }

        [TestMethod]
        public void TestMethodLoginAdmin()
        {
            User user = new User();
            user.Username = "dandi";
            user.Password = "12341234";
            user.Role = "Admin";
            user.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user });
            LoginManager loginManager = new LoginManager(fakeAccRepo);
            
            Assert.AreEqual(user.Username, loginManager.Login("dandi", "12341234").Username);
            Assert.AreEqual(user.Role, loginManager.Login("dandi", "12341234").Role);
        }

        [TestMethod]
        public void TestMethodEmptyInformationFields()
        {
            User user = new User();
            user.Username = "dandi";
            user.Password = "12341234";
            user.Role = "Admin";
            user.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user });
            LoginManager loginManager = new LoginManager(fakeAccRepo);

            string username = string.Empty;
            string password = string.Empty;
            Assert.AreEqual(null, loginManager.Login(username, password));
        }
    }
}
