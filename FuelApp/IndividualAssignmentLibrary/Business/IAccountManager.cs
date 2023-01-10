using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Business
{
    public interface IAccountManager
    {
        public bool CreateAccount(string username, string password, long cardNumber, DateTime cardValidThru, int cardCVC, string zipCode, long phoneNumber);

        public Customer GetCustomerByUsername(string username);

        public bool UpdateAccountInfo(Customer customer);

        public bool UpdatePaymentInfo(Customer customer);
    }
}
