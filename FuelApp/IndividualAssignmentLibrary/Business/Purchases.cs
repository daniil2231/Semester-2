using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class Purchases
    {
        public string Username { get; set; }

        public string ZipCode { get; set; }

        public string FuelName { get; set; }

        public double LitersPurchased { get; set; }

        public double Cost { get; set; }

        public override string ToString()
        {
            return $"Buyer: {Username}, Zip code: {ZipCode}, Fuel name: {FuelName}, Liters purchased: {LitersPurchased}, Cost: {Cost:f2}";
        }
    }
}
