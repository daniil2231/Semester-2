using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;

namespace UnitTests.Persistence
{
    public class FakeFuelRepository : IFuelRepository
    {
        List<Fuel> fuels;
        List<Purchases> purchases;

        public FakeFuelRepository(List<Fuel> fuels, List<Purchases> purchases)
        {
            this.fuels = fuels;
            this.purchases = purchases;
        }

        public FakeFuelRepository(List<Fuel> fuels)
        {
            this.fuels = fuels;
        }

        public FakeFuelRepository(List<Purchases> purchases)
        {
            this.purchases = purchases;
        }

        public bool AddCNG(CompressedNaturalGas CNG)
        {
            fuels.Add(CNG);
            if (fuels.Last<Fuel>() == CNG)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddDiesel(Diesel diesel)
        {
            fuels.Add(diesel);
            if (fuels.Last<Fuel>() == diesel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuyFuel(Fuel fuel, Customer customer, double litersPurchased, double cost)
        {
            Purchases purchase = new Purchases();
            purchase.FuelName = fuel.FuelName;
            purchase.Username = customer.Username;
            purchase.ZipCode = customer.ZipCode;
            purchase.LitersPurchased = litersPurchased;
            purchase.Cost = cost;

            purchases.Add(purchase);
            if (purchases.Last<Purchases>() == purchase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCNG(CompressedNaturalGas CNG)
        {
            fuels.Remove(CNG);
            if (fuels.Contains(CNG) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDiesel(Diesel diesel)
        {
            fuels.Remove(diesel);
            if (fuels.Contains(diesel) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditCNGPrice(CompressedNaturalGas cng, double newPrice)
        {
            foreach (Fuel fuel in fuels)
            {
                if (fuel.FuelName == cng.FuelName)
                {
                    fuel.PricePerLiter = newPrice;
                    return true;
                }
            }
            return false;
        }

        public bool EditDieselPrice(Diesel diesel, double newPrice)
        {
            foreach (Fuel fuel in fuels)
            {
                if (fuel.FuelName == diesel.FuelName)
                {
                    fuel.PricePerLiter = newPrice;
                    return true;
                }
            }
            return false;
        }

        public CompressedNaturalGas FindCNG(string fuelName)
        {
            foreach (Fuel fuel in fuels)
            {
                if (fuel.FuelName == fuelName)
                {
                    return (CompressedNaturalGas)fuel;
                }
            }

            return null;
        }

        public Diesel FindDiesel(string fuelName)
        {
            foreach (Fuel fuel in fuels)
            {
                if (fuel.FuelName == fuelName)
                {
                    return (Diesel)fuel;
                }
            }

            return null;
        }

        public List<CompressedNaturalGas> GetCNGs()
        {
            List<CompressedNaturalGas> cngs = new List<CompressedNaturalGas>();
            CompressedNaturalGas cng = new CompressedNaturalGas();

            foreach (Fuel fuel in fuels)
            {
                if (fuel.GetType() == cng.GetType())
                {
                    cngs.Add((CompressedNaturalGas)fuel);
                }
            }

            return cngs;
        }

        public List<Diesel> GetDiesels()
        {
            List<Diesel> diesels = new List<Diesel>();
            Diesel diesel = new Diesel();

            foreach (Fuel fuel in fuels)
            {
                if (fuel.GetType() == diesel.GetType())
                {
                    diesels.Add((Diesel)fuel);
                }
            }

            return diesels;
        }

        public List<Purchases> GetSalesHistory()
        {
            return purchases;
        }
    }
}
