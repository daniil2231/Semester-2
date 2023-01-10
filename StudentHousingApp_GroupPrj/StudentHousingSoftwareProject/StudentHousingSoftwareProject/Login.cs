using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingSoftwareProject
{
    public class Login
    {
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }

        public Login(string loginUsername, string loginPassword)
        {
            LoginUsername = loginUsername;
            LoginPassword = loginPassword;
        }

        public Login()
        {
           
        }

        public string LoginCheck(List<Tenant> tenantList, List<Agency> adminList)
        {
            for (int i = 0; i < tenantList.Count ; i++)
            {
                if (LoginUsername == tenantList[i].TenantName)
                {
                    if (LoginPassword == tenantList[i].TenantPassword)
                    {
                        return "student";
                    }
                }

            }
            for (int i = 0; i < adminList.Count ; i++)
            {
                if (LoginUsername == adminList[i].AgencyUsername)
                {
                    if (LoginPassword == "admin")
                    {
                        return "admin";
                    }
                }
            }
            return "error";
        }
    }
}
