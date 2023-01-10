using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class User
    {
        [Required(ErrorMessage = "Please supply a username")]
        [StringLength(8, ErrorMessage = "Please supply a username with atleast 8 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please supply a password")]
        [StringLength(8, ErrorMessage = "Please supply a password with atleast 8 characters")]
        public string Password { get; set; }

        public string Role { get; set; }

        public int Id { get; set; }

        public User(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public User()
        {

        }
    }
}
