using IndividualAssignmentLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Persistence
{
    public class AccountRepository : IAccountRepository
    {
        public User FindUser(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select * from users where username=@username and password=@password";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    conn.Open();
                    User user = new User();
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        user.Username = dataReader.GetString("username");
                        user.Password = dataReader.GetString("password");
                        user.Role = dataReader.GetString("role");
                    }

                    return user;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public Customer GetCustomerByUsername(string username)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "SELECT users.username, users.password, users.idcustomer, customer.cardNumber, customer.cardValidThru, customer.cardCVC, customer.zipCode, customer.phoneNumber FROM users INNER JOIN customer ON users.idcustomer=customer.id where username=@username";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("username", username);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    Customer customer = null;
                    while (dr.Read())
                    {
                        customer = new Customer();
                        customer.Id = dr.GetInt32("idcustomer");
                        customer.Username = dr.GetString("username");
                        customer.Password = dr.GetString("password");
                        customer.CardNumber = dr.GetInt64("cardNumber");
                        customer.CardValidThru = dr.GetDateTime("cardValidThru");
                        customer.CardCVC = dr.GetInt32("cardCVC");
                        customer.ZipCode = dr.GetString("zipCode");
                        customer.PhoneNumber = dr.GetInt64("phoneNumber");
                    }
                    return customer;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public bool Create(string username, string password, long cardNumber, DateTime cardValidThru, int cardCVC, string zipCode, long phoneNumber, string role)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql;
                    sql = "INSERT INTO customer (cardNumber,cardValidThru,cardCVC,zipCode,phoneNumber) values (@cardNumber,@cardValidThru,@cardCVC,@zipCode,@phoneNumber)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("cardNumber", cardNumber);
                    cmd.Parameters.AddWithValue("cardValidThru", cardValidThru);
                    cmd.Parameters.AddWithValue("cardCVC", cardCVC);
                    cmd.Parameters.AddWithValue("zipCode", zipCode);
                    cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    long customerId = cmd.LastInsertedId;

                    sql = "insert into users (username,password,role,idcustomer) values (@username,@password,@role,@customerId)";
                    cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("role", role);
                    cmd.Parameters.AddWithValue("customerId", customerId);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public bool UpdateCustomerAccountInfo(Customer customer)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "UPDATE users SET password=@password WHERE username=@username";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("password", customer.Password);
                    cmd.Parameters.AddWithValue("username", customer.Username);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public bool UpdateCustomerPaymentInfo(Customer customer)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "UPDATE customer SET cardNumber=@cardNumber,cardValidThru=@cardValidThru,cardCVC=@cardCVC,zipCode=@zipCode,phoneNumber=@phoneNumber WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("cardNumber", customer.CardNumber);
                    cmd.Parameters.AddWithValue("cardValidThru", customer.CardValidThru);
                    cmd.Parameters.AddWithValue("cardCVC", customer.CardCVC);
                    cmd.Parameters.AddWithValue("zipCode", customer.ZipCode);
                    cmd.Parameters.AddWithValue("phoneNumber", customer.PhoneNumber);
                    cmd.Parameters.AddWithValue("id", customer.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }
    }
}
