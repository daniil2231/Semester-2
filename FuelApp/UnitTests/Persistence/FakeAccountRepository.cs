using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Persistence
{
    public class FakeAccountRepository : IAccountRepository
    {
        List<User> users;
        List<Customer> customers;

        public FakeAccountRepository(List<User> users, List<Customer> customers)
        {
            this.users = users;
            this.customers = customers;
        }

        public FakeAccountRepository(List<User> users)
        {
            this.users = users;
        }

        public FakeAccountRepository(List<Customer> customers)
        {
            this.customers = customers;
        }

        public bool Create(string username, string password, long cardNumber, DateTime cardValidThru, int cardCVC, string zipCode, long phoneNumber, string role)
        {
            User user = new User();
            Customer customer = new Customer();

            user.Username = username;
            user.Password = password;
            user.Role = role;
            if (users.Count == 0)
            {
                user.Id = 1;
            }
            else
            {
                user.Id = users.Last<User>().Id + 1;
            }
            customer.CardNumber = cardNumber;
            customer.CardValidThru = cardValidThru;
            customer.CardCVC = cardCVC;
            customer.ZipCode = zipCode;
            customer.PhoneNumber = phoneNumber;
            if (customers.Count == 0)
            {
                customer.Id = 1;
            }
            else
            {
                customer.Id = customers.Last<Customer>().Id + 1;
            }

            if (users.Contains(user) == false && customers.Contains(customer) == false)
            {
                users.Add(user);
                customers.Add(customer);

                return true;
            }
            else
            {
                return false;
            }
        }

        public User FindUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public Customer GetCustomerByUsername(string username)
        {
            foreach (Customer customer in customers)
            {
                foreach (User user in users)
                {
                    if (user.Username == username && user.Id == customer.Id)
                    {
                        return customer;
                    }
                }
            }

            return null;
        }

        public bool UpdateCustomerAccountInfo(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customer.Id)
                {
                    customers[i].Password = customer.Password;
                    return true;
                }
            }
            return false;
        }

        public bool UpdateCustomerPaymentInfo(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customer.Id)
                {
                    customers[i].CardNumber = customer.CardNumber;
                    customers[i].CardValidThru = customer.CardValidThru;
                    customers[i].CardCVC = customer.CardCVC;
                    customers[i].ZipCode = customer.ZipCode;
                    customers[i].PhoneNumber = customer.PhoneNumber;
                    return true;
                }
            }
            return false;
        }
    }
}
