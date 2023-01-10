using IndividualAssignmentLibrary.Business;
using IndividualAssignmentLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAssignmentLibrary
{
    public class FuelManager : IFuelManager
    {
        IFuelRepository fuelRepository;

        public FuelManager(IFuelRepository repo)
        {
            fuelRepository = repo;
        }

        public FuelManager()
        {
            fuelRepository = new FuelRepository();
        }

        public bool BuyFuel(Fuel fuel, Customer customer, double liters)
        {
            double cost = fuel.PricePerLiter * liters;
            return fuelRepository.BuyFuel(fuel, customer, liters, cost);
        }

        public List<Purchases> GetSalesHistory()
        {
            return fuelRepository.GetSalesHistory();
        }

        public bool CreateDiesel(Diesel diesel)
        {
            return fuelRepository.AddDiesel(diesel);
        }

        public bool CreateCNG(CompressedNaturalGas CNG)
        {
            return fuelRepository.AddCNG(CNG);
        }

        public Diesel FindDiesel(string dieselName)
        {
            return fuelRepository.FindDiesel(dieselName);
        }

        public CompressedNaturalGas FindCNG(string CNGName)
        {
            return fuelRepository.FindCNG(CNGName);
        }

        public bool EditDieselPrice(Diesel diesel, double newPrice)
        {
            return fuelRepository.EditDieselPrice(diesel, newPrice);
        }

        public bool EditCNGPrice(CompressedNaturalGas CNG, double newPrice)
        {
            return fuelRepository.EditCNGPrice(CNG, newPrice);
        }

        public bool RemoveDiesel(Diesel diesel)
        {
            return fuelRepository.DeleteDiesel(diesel);
        }

        public bool RemoveCNG(CompressedNaturalGas CNG)
        {
            return fuelRepository.DeleteCNG(CNG);
        }

        public List<Diesel> GetDiesels()
        {
            return fuelRepository.GetDiesels();
        }

        public List<CompressedNaturalGas> GetCNGs()
        {
            return fuelRepository.GetCNGs();
        }
    }
}
