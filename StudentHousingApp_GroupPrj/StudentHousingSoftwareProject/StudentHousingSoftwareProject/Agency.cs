using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingSoftwareProject
{
    public class Agency
    {
        string agencyUsername;
        string agencyPassword;

        public string AgencyUsername 
        {
            get 
            {
                return agencyUsername;
            }
            set
            {
                this.agencyUsername = value;
            } 
        }

        public string AgencyPassword
        {
            get
            {
                return this.agencyPassword;
            }
            set
            {
                this.agencyPassword = value;
            }
        }

        public Agency(string agencyUsername, string agencyPassword)
        {
             this.agencyUsername = agencyUsername;
             this.agencyPassword = agencyPassword;
        }

        public Agency()
        {

        }
    }
}
