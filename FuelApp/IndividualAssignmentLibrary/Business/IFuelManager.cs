using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Business
{
    public interface IFuelManager
    {
        public bool BuyFuel(Fuel fuel, Customer customer, double liters);

        public List<Purchases> GetSalesHistory();

        public bool CreateDiesel(Diesel diesel);

        public bool CreateCNG(CompressedNaturalGas CNG);

        public Diesel FindDiesel(string dieselName);

        public CompressedNaturalGas FindCNG(string CNGName);

        public bool EditDieselPrice(Diesel diesel, double newPrice);

        public bool EditCNGPrice(CompressedNaturalGas CNG, double newPrice);

        public bool RemoveDiesel(Diesel diesel);

        public bool RemoveCNG(CompressedNaturalGas CNG);

        public List<Diesel> GetDiesels();

        public List<CompressedNaturalGas> GetCNGs();
    }
}
