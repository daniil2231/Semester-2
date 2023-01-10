using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Business
{
    public class DatabaseException : Exception
    {
        public DatabaseException() : base() { }

        public DatabaseException(string message) : base(message) { }

        public DatabaseException(string message, Exception e) : base(message, e) { }

        private string extraInfo = "Oops! There appears to be a problem with the database :(";

        public string ExtraInfo
        {
            get { return extraInfo; }
            set { extraInfo = value; }
        }
    }
}
