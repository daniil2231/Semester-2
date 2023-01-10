using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Persistence;

namespace UnitTests.Business
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void CreateAccountTestSuccess()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "dandi2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "Customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>(), new List<Customer>());
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsTrue(accountManager.CreateAccount("dandi2231", "12341234", 1892389123, new DateTime(20/10/2022), 900, "9898GP", 9988887773333));
        }

        [TestMethod]
        public void CreateAccountTestFail()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user }, new List<Customer>() { customer });
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsFalse(accountManager.CreateAccount(user.Username, user.Password, customer.CardNumber, customer.CardValidThru, customer.CardCVC, customer.ZipCode, customer.PhoneNumber));
        }

        [TestMethod]
        public void FindCustomerTestSuccess()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user }, new List<Customer>() { customer });
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.AreEqual(customer, accountManager.GetCustomerByUsername("danito2231"));
        }

        [TestMethod]
        public void FindCustomerTestShouldReturnNull()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>(), new List<Customer>());
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsNull(accountManager.GetCustomerByUsername("danito2231"));
        }

        [TestMethod]
        public void EditCustomerAccountInfoTestSuccess()
        {
            //For the next methods I couldn't really find a way to fully show them in tests since I change the customer's fields in presentation
            //and pass the whole object. The fail ones are to show that if there is no object to be updated it will return false.
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "Customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user }, new List<Customer>() { customer });
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsTrue(accountManager.UpdateAccountInfo(customer));
        }

        [TestMethod]
        public void EditCustomerAccountInfoTestShouldReturnFalse()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "Customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>(), new List<Customer>());
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsFalse(accountManager.UpdateAccountInfo(customer));
        }

        [TestMethod]
        public void EditCustomerPaymentInfoTestSuccess()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "Customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>() { user }, new List<Customer>() { customer });
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsTrue(accountManager.UpdatePaymentInfo(customer));
        }

        [TestMethod]
        public void EditCustomerPaymentInfoTestShouldReturnFalse()
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = "danito2231";
            user.Password = "12341234";
            user.Role = "Customer";
            user.Id = 1;

            customer.CardNumber = 12344321;
            customer.CardValidThru = new DateTime(20 / 04 / 2022);
            customer.CardCVC = 123;
            customer.ZipCode = "1234GP";
            customer.PhoneNumber = 123667213;
            customer.Role = "Customer";
            customer.Id = 1;

            IAccountRepository fakeAccRepo = new FakeAccountRepository(new List<User>(), new List<Customer>());
            AccountManager accountManager = new AccountManager(fakeAccRepo);

            Assert.IsFalse(accountManager.UpdatePaymentInfo(customer));
        }
    }
}
