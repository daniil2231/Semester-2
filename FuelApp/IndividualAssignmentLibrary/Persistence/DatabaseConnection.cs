using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Persistence
{
    public class DatabaseConnection
    {
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476545;Database=dbi476545;Pwd=12341234;");
        }
    }
}
