using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please supply a username")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Please supply a username with atleast 8 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please supply a password")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Please supply a password with atleast 8 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please supply a payment card number")]
        [DataType(DataType.CreditCard)]
        public long CardNumber { get; set; }

        [Required(ErrorMessage = "Please supply a payment card expiry date")]
        [DisplayFormat(DataFormatString = "{MM/yyyy}")]
        public DateTime CardValidThru { get; set; }

        [Required(ErrorMessage = "Please supply a payment card CVC")]
        public int CardCVC { get; set; }

        [Required(ErrorMessage = "Please supply a zip code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please supply a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public long PhoneNumber { get; set; }

        public string Role { get; set; }

        public Customer(string username, string password, long cardNumber, DateTime cardValidThru, int cardCVC, string zipCode, long phoneNumber)
        {
            this.Username = username;
            this.Password = password;
            this.CardNumber = cardNumber;
            this.CardValidThru = cardValidThru;
            this.CardCVC = cardCVC;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.Role = "Customer";
        }

        public Customer()
        {

        }
    }
}
