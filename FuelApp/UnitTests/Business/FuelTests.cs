using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Persistence;

namespace UnitTests.Business
{
    [TestClass]
    public class FuelTests
    {
        [TestMethod]
        public void AddCNGTest()
        {
            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>());
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG92";
            cng.PricePerLiter = 2.22;
            cng.Purity = 92;
            cng.AirflowResistance = 0.7;
            cng.Suitability = "All gas engines";

            bool addCNG = fuelManager.CreateCNG(cng);

            Assert.IsTrue(addCNG);
        }

        [TestMethod]
        public void AddDieselTest()
        {
            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>());
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.92;
            diesel.Purity = 98;
            diesel.Viscosity = 0.7;
            diesel.Suitability = "All diesel engines";

            Assert.IsTrue(fuelManager.CreateDiesel(diesel));
        }

        [TestMethod]
        public void FindCNGTestSuccess()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { cng });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.AreEqual(cng, fuelManager.FindCNG("CNG91"));
        }

        [TestMethod]
        public void FindDieselTestSuccess()
        {
            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.92;
            diesel.Purity = 98;
            diesel.Viscosity = 0.7;
            diesel.Suitability = "All diesel engines";

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { diesel });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.AreEqual(diesel, fuelManager.FindDiesel("Diesel1"));
        }

        [TestMethod]
        public void FindCNGTestShouldReturnNull()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { cng });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsNull(fuelManager.FindCNG("CNG"));
        }

        public void FindDieselTestShouldReturnNull()
        {
            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.92;
            diesel.Purity = 98;
            diesel.Viscosity = 0.7;
            diesel.Suitability = "All diesel engines";

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>());
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsNull(fuelManager.FindDiesel("Diesel1"));
        }

        [TestMethod]
        public void DeleteCNGTest()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { cng });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.RemoveCNG(cng));
        }

        [TestMethod]
        public void DeleteDieselTest()
        {
            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.92;
            diesel.Purity = 98;
            diesel.Viscosity = 0.7;
            diesel.Suitability = "All diesel engines";

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { diesel });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.RemoveDiesel(diesel));
        }

        [TestMethod]
        public void EditCNGPriceTest()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";
            double newPrice = 2.40;

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { cng });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.EditCNGPrice(cng, newPrice));
        }

        [TestMethod]
        public void EditDieselPriceTest()
        {
            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.92;
            diesel.Purity = 98;
            diesel.Viscosity = 0.7;
            diesel.Suitability = "All diesel engines";
            double newPrice = 2.99;

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Fuel>() { diesel });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.EditDieselPrice(diesel, newPrice));
        }

        [TestMethod]
        public void GetAllCNGsTest()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.55;
            diesel.Purity = 98;
            diesel.Viscosity = 0.98;
            diesel.Suitability = "All gas engines";

            List<Fuel> fuels = new List<Fuel>();
            fuels.Add(diesel);
            fuels.Add(cng);

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(fuels);
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.GetCNGs().Count == 1);
            Assert.IsTrue(fuelManager.GetCNGs().Contains(cng));
        }

        [TestMethod]
        public void GetAllDieselsTest()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            Diesel diesel = new Diesel();
            diesel.FuelName = "Diesel1";
            diesel.PricePerLiter = 2.55;
            diesel.Purity = 98;
            diesel.Viscosity = 0.98;
            diesel.Suitability = "All gas engines";

            List<Fuel> fuels = new List<Fuel>();
            fuels.Add(diesel);
            fuels.Add(cng);

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(fuels);
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.GetDiesels().Count == 1);
            Assert.IsTrue(fuelManager.GetDiesels().Contains(diesel));
        }

        [TestMethod]
        public void GetPurchasesTestSuccess()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            Customer customer = new Customer();
            customer.Username = "dan";
            customer.Password = "12341234";
            customer.CardNumber = 12312312434123;
            customer.CardValidThru = new DateTime(20/11/2022);
            customer.CardCVC = 343;
            customer.ZipCode = "1212GP";
            customer.PhoneNumber = 884832010;

            double litersPurchased = 10.5;

            Purchases purchase = new Purchases();
            purchase.Username = customer.Username;
            purchase.FuelName = cng.FuelName;
            purchase.ZipCode = customer.ZipCode;
            purchase.LitersPurchased = litersPurchased;
            purchase.Cost = cng.PricePerLiter * litersPurchased;

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Purchases>() { purchase });
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsTrue(fuelManager.GetSalesHistory().Contains(purchase));
        }

        [TestMethod]
        public void GetPurchasesTestFail()
        {
            CompressedNaturalGas cng = new CompressedNaturalGas();
            cng.FuelName = "CNG91";
            cng.PricePerLiter = 2.35;
            cng.Purity = 91;
            cng.AirflowResistance = 0.98;
            cng.Suitability = "All gas engines";

            Customer customer = new Customer();
            customer.Username = "dan";
            customer.Password = "12341234";
            customer.CardNumber = 12312312434123;
            customer.CardValidThru = new DateTime(20 / 11 / 2022);
            customer.CardCVC = 343;
            customer.ZipCode = "1212GP";
            customer.PhoneNumber = 884832010;

            double litersPurchased = 10.5;

            Purchases purchase = new Purchases();
            purchase.Username = customer.Username;
            purchase.FuelName = cng.FuelName;
            purchase.ZipCode = customer.ZipCode;
            purchase.LitersPurchased = litersPurchased;
            purchase.Cost = cng.PricePerLiter * litersPurchased;

            IFuelRepository fakeFuelRepo = new FakeFuelRepository(new List<Purchases>());
            FuelManager fuelManager = new FuelManager(fakeFuelRepo);

            Assert.IsFalse(fuelManager.GetSalesHistory().Contains(purchase));
        }
    }
}
