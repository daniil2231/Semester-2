using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public abstract class Fuel
    {
        [Required (ErrorMessage = "Please supply a fuel name")]
        public string FuelName { get; set; }

        [Required (ErrorMessage = "Please supply a price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please supply a valid price")]
        public double PricePerLiter { get; set; }

        [Required (ErrorMessage = "Please supply suitability")]
        public string Suitability { get; set; }

        [Required (ErrorMessage = "Please supply purity")]
        [Range(1, 100, ErrorMessage = "Please supply purity (from 1-100)")]
        public int Purity { get; set; }

        public Fuel(string fuelName, double pricePerLiter, string suitability, int purity)
        {
            this.FuelName = fuelName;
            this.PricePerLiter = pricePerLiter;
            this.Suitability = suitability;
            this.Purity = purity;
        }

        public Fuel()
        {

        }

        public abstract double CalculateFillUpTime(double liters);
    }
}
