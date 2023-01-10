using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Business
{
    public interface ILoginManager
    {
        public User Login(string username, string password);
    }
}
