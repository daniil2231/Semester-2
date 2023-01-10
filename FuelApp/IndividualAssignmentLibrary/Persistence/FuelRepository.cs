using IndividualAssignmentLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Persistence
{
    public class FuelRepository : IFuelRepository
    {
        public bool AddDiesel(Diesel diesel)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into diesel (dieselName,pricePerLiter,suitability,purity,viscosity) values (@dieselName,@pricePerLiter,@suitability,@purity,@viscosity)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("dieselName", diesel.FuelName);
                    cmd.Parameters.AddWithValue("pricePerLiter", diesel.PricePerLiter);
                    cmd.Parameters.AddWithValue("suitability", diesel.Suitability);
                    cmd.Parameters.AddWithValue("purity", diesel.Purity);
                    cmd.Parameters.AddWithValue("viscosity", diesel.Viscosity);

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

        public bool AddCNG(CompressedNaturalGas CNG)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into compressednaturalgas (cngName,pricePerLiter,suitability,purity,airflowResistance) values (@cngName,@pricePerLiter,@suitability,@purity,@airflowResistance)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("cngName", CNG.FuelName);
                    cmd.Parameters.AddWithValue("pricePerLiter", CNG.PricePerLiter);
                    cmd.Parameters.AddWithValue("suitability", CNG.Suitability);
                    cmd.Parameters.AddWithValue("purity", CNG.Purity);
                    cmd.Parameters.AddWithValue("airflowResistance", CNG.AirflowResistance);

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

        public bool BuyFuel(Fuel fuel, Customer customer, double litersPurchased, double cost)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "INSERT into saleshistory (username,zipCode,fuelName,litersPurchased,cost) values (@username, @zipCode, @fuelName, @litersPurchased, @cost)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("username", customer.Username);
                    cmd.Parameters.AddWithValue("zipCode", customer.ZipCode);
                    cmd.Parameters.AddWithValue("fuelName", fuel.FuelName);
                    cmd.Parameters.AddWithValue("litersPurchased", litersPurchased);
                    cmd.Parameters.AddWithValue("cost", cost);

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

        public List<Purchases> GetSalesHistory()
        {
            try
            {
                List<Purchases> purchases = new List<Purchases>();
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select username, zipCode, fuelName, litersPurchased, cost from saleshistory";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    Purchases purchase;
                    while (dr.Read())
                    {
                        purchase = new Purchases();
                        purchase.Username = dr.GetString("username");
                        purchase.ZipCode = dr.GetString("zipCode");
                        purchase.FuelName = dr.GetString("fuelName");
                        purchase.LitersPurchased = dr.GetDouble("litersPurchased");
                        purchase.Cost = dr.GetDouble("cost");
                        purchases.Add(purchase);
                    }
                }
                return purchases;
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public Diesel FindDiesel(string fuelName)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select * from diesel where dieselName=@dieselName";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("dieselName", fuelName);

                    conn.Open();
                    Diesel diesel = new Diesel();
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        diesel.FuelName = dataReader.GetString("dieselName");
                        diesel.PricePerLiter = dataReader.GetDouble("pricePerLiter");
                        diesel.Purity = dataReader.GetInt32("purity");
                        diesel.Viscosity = dataReader.GetDouble("viscosity");
                        diesel.Suitability = dataReader.GetString("suitability");
                    }

                    return diesel;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public CompressedNaturalGas FindCNG(string fuelName)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select * from compressednaturalgas where cngName=@cngName";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("cngName", fuelName);

                    conn.Open();
                    CompressedNaturalGas cng = new CompressedNaturalGas();
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        cng.FuelName = dataReader.GetString("cngName");
                        cng.PricePerLiter = dataReader.GetDouble("pricePerLiter");
                        cng.Purity = dataReader.GetInt32("purity");
                        cng.AirflowResistance = dataReader.GetDouble("airflowResistance");
                        cng.Suitability = dataReader.GetString("suitability");
                    }

                    return cng;
                }
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public bool EditDieselPrice(Diesel diesel, double newPrice)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "UPDATE diesel SET pricePerLiter=@pricePerLiter WHERE dieselName=@dieselName";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("pricePerLiter", newPrice);
                    cmd.Parameters.AddWithValue("dieselName", diesel.FuelName);

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

        public bool EditCNGPrice(CompressedNaturalGas cng, double newPrice)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "UPDATE compressednaturalgas SET pricePerLiter=@pricePerLiter WHERE cngName=@cngName";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("pricePerLiter", newPrice);
                    cmd.Parameters.AddWithValue("cngName", cng.FuelName);

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

        public bool DeleteDiesel(Diesel diesel)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from diesel where dieselName=@dieselName";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("dieselName", diesel.FuelName);

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

        public bool DeleteCNG(CompressedNaturalGas CNG)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from compressednaturalgas where cngName=@cngName";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("cngName", CNG.FuelName);

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

        public List<Diesel> GetDiesels()
        {
            try
            {
                List<Diesel> diesels = new List<Diesel>();
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
                {

                    string sql = "SELECT * FROM diesel";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();


                    Diesel diesel = null;
                    while (dr.Read())
                    {
                        diesel = new Diesel();
                        diesel.FuelName = dr.GetString("dieselName");
                        diesel.PricePerLiter = dr.GetDouble("pricePerLiter");
                        diesel.Purity = dr.GetInt32("purity");
                        diesel.Viscosity = dr.GetDouble("viscosity");
                        diesel.Suitability = dr.GetString("suitability");
                        diesels.Add(diesel);
                    }
                }

                return diesels;
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }

        public List<CompressedNaturalGas> GetCNGs()
        {
            try
            {
                List<CompressedNaturalGas> CNGs = new List<CompressedNaturalGas>();
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
                {

                    string sql = "SELECT * FROM compressednaturalgas";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();


                    CompressedNaturalGas CNG = null;
                    while (dr.Read())
                    {
                        CNG = new CompressedNaturalGas();
                        CNG.FuelName = dr.GetString("cngName");
                        CNG.PricePerLiter = dr.GetDouble("pricePerLiter");
                        CNG.Purity = dr.GetInt32("purity");
                        CNG.AirflowResistance = dr.GetDouble("airflowResistance");
                        CNG.Suitability = dr.GetString("suitability");
                        CNGs.Add(CNG);
                    }
                }

                return CNGs;
            }
            catch (Exception)
            {
                throw new DatabaseException();
            }
        }
    }
}
