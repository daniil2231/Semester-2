using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class Diesel : Fuel
    {
        [Required (ErrorMessage ="Please supply viscosity")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please supply valid viscosity")]
        public double Viscosity { get; set; }

        public Diesel(string fuelName, double pricePerLiter, string suitability, int purity, double viscosity) : base(fuelName, pricePerLiter, suitability, purity)
        {
            this.FuelName = fuelName;
            this.PricePerLiter = pricePerLiter;
            this.Suitability = suitability;
            this.Purity = purity;
            this.Viscosity = viscosity;
        }

        public Diesel()
        {

        }

        public override double CalculateFillUpTime(double liters)
        {
            return (liters * 4) / 6 + Viscosity / 60;
        }
    }
}
