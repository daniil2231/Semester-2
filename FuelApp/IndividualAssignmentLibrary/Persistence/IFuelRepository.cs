using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary.Persistence
{
    public interface IFuelRepository
    {
        public bool AddDiesel(Diesel diesel);

        public bool AddCNG(CompressedNaturalGas CNG);

        public bool BuyFuel(Fuel fuel, Customer customer, double litersPurchased, double cost);

        public List<Purchases> GetSalesHistory();

        public Diesel FindDiesel(string fuelName);

        public CompressedNaturalGas FindCNG(string fuelName);

        public bool EditDieselPrice(Diesel diesel, double newPrice);

        public bool EditCNGPrice(CompressedNaturalGas cng, double newPrice);

        public bool DeleteDiesel(Diesel diesel);

        public bool DeleteCNG(CompressedNaturalGas CNG);

        public List<Diesel> GetDiesels();

        public List<CompressedNaturalGas> GetCNGs();
    }
}
