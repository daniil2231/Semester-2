using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Persistence
{
    public interface IAccountRepository
    {
        public User FindUser(string username, string password);

        public Customer GetCustomerByUsername(string username);

        public bool Create(string username, string password, long cardNumber, DateTime cardValidThru, int cardCVC, string zipCode, long phoneNumber, string role);

        public bool UpdateCustomerAccountInfo(Customer customer);

        public bool UpdateCustomerPaymentInfo(Customer customer);
    }
}
