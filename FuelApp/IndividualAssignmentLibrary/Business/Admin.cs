using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class Admin
    {
        private string username;
        private string password;
        public string Role { get; set; }

        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.Role = "Admin";
        }

        public Admin()
        {

        }
    }
}
