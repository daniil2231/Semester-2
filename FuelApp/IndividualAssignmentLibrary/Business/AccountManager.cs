using IndividualAssignmentLibrary.Business;
using IndividualAssignmentLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class AccountManager : IAccountManager
    {
        private IAccountRepository accountRepository;

        public AccountManager(IAccountRepository repo)
        {
            accountRepository = repo;
        }

        public AccountManager()
        {
            accountRepository = new AccountRepository();
        }

        public bool CreateAccount(string username, string password, long cardNumber, DateTime cardValidThru, int cardCVC, string zipCode, long phoneNumber)
        {
            Customer customer = accountRepository.GetCustomerByUsername(username);
            if (customer == null)
            {
                accountRepository.Create(username, password, cardNumber, cardValidThru, cardCVC, zipCode, phoneNumber, "Customer");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Customer GetCustomerByUsername(string username)
        {
            return accountRepository.GetCustomerByUsername(username);
        }

        public bool UpdateAccountInfo(Customer customer)
        {
            return accountRepository.UpdateCustomerAccountInfo(customer);
        }

        public bool UpdatePaymentInfo(Customer customer)
        {
            return accountRepository.UpdateCustomerPaymentInfo(customer);
        }
    }
}
