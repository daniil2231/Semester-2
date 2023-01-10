using IndividualAssignmentLibrary.Business;
using IndividualAssignmentLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class LoginManager : ILoginManager
    {
        private IAccountRepository accountRepository;

        public LoginManager(IAccountRepository repo)
        {
            accountRepository = repo;
        }

        public User Login(string username, string password)
        {
            User user = accountRepository.FindUser(username, password);

            return user;
        }
    }
}
