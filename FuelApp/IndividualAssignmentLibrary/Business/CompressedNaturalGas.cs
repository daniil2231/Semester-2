using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class CompressedNaturalGas : Fuel
    {
        [Required (ErrorMessage = "Please supply airflow resistance")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please supply valid airflow resistance")]
        public double AirflowResistance { get; set; }

        public CompressedNaturalGas(string fuelName, double pricePerLiter, string suitability, int purity, double airflowResistance) : base(fuelName, pricePerLiter, suitability, purity)
        {
            this.FuelName = fuelName;
            this.PricePerLiter = pricePerLiter;
            this.Suitability = suitability;
            this.Purity = purity;
            this.AirflowResistance = airflowResistance;
        }

        public CompressedNaturalGas()
        {

        }

        public override double CalculateFillUpTime(double liters)
        {
            return (liters * 4) / 6 + AirflowResistance / 60;
        }
    }
}
