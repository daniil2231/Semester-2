using DeliverablesApp.logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MyFirstUnitTestProject
{
    [TestClass]
    public class MyFirstUnitTest
    {
        [TestMethod]
        public void TestCreateADeliverable()
        {// testing to create a deliverable
            Deliverable d = new Deliverable(22, 350, "John", "Mainstreet", 2, "5688GE", "Eindhoven");

            Assert.AreEqual(d.ID, 22);
            Assert.AreEqual(d.Name, "John");
            Assert.AreEqual(d.Street, "Mainstreet");
            Assert.AreEqual(d.Housenumber, 2);
            Assert.AreEqual(d.Postalcode, "5688GE");
            Assert.AreEqual(d.City, "Eindhoven");
        }

        [TestMethod]
        public void TestCreateAnEmptyTransport()
        {// testing to create an empty transport (a transport with 0 deliverables)
            Transport t = new Transport();

            Assert.AreEqual(t.Deliverables.Count, 0);
        }

        [TestMethod]
        public void TestAddADeliverableToATransport()
        {// testing to  add a deliverablen to a transport
            Deliverable d1 = new Deliverable(22, 350, "Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Transport t = new Transport();

            t.AddDeliverable(d1);
            Deliverable d2 = t.FindDeliverable(22);

            Assert.AreEqual(d2.Name, "Josephine");
            Assert.AreEqual(d2.Street, "Nieuwstraat");
        }

        [TestMethod]
        public void TestAdd2DeliverablesToATransport()
        {
            // To do:
            // Add two deliverables with different id's to a transport-object.
            // Check if it works 
            Transport t = new Transport();
            Deliverable d1 = new Deliverable(1, 350, "Sven Kramer", "MainStreet", 33, "5688GE", "Eindhoven");
            t.AddDeliverable(d1);
            Deliverable d2 = new Deliverable(2, 700, "Adele", "Kerkstraat", 13, "5688DE", "Eindhoven");
            t.AddDeliverable(d2);
            List<Deliverable> expectedDeliverables = new List<Deliverable>() { d1, d2 };
            CollectionAssert.AreEqual(expectedDeliverables, t.Deliverables);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAddDeliverablesWithDuplicateIDToATransport()
        {
            // To do:
            // Try to add 2 deliverables with the same id to a transport-object 
            // An exception should be thrown
            // Check if it works.
            Transport t = new Transport();
            t.AddDeliverable(new Deliverable(1, 350, "Sven Kramer", "MainStreet", 33, "5688GE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(1, 100, "James Kramer", "Second Street", 10, "5688AB", "Amsterdam"));
        }

        
        [TestMethod]
        public void TestFindHeaviestInATransportOf1()
        {// testing to find heaviest deliverable in a transport of size 1
            Transport t = new Transport();
            Deliverable d = new Deliverable(22, 350, "Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            t.AddDeliverable(d);

            d = t.FindHeaviestDeliverable();

            Assert.AreEqual(d.Weight, 350);
            Assert.AreEqual(d.ID, 22);
        }

        [TestMethod]
        public void TestFindHeaviestInATransportOf2()
        {// testing to find heaviest deliverable in a transport of size 1
            Transport t = new Transport();

            Deliverable d1 = new Deliverable(22, 350, "Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            t.AddDeliverable(d1);
            Deliverable d2 = new Deliverable(35, 750, "Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven");
            t.AddDeliverable(d2);

            Deliverable d = t.FindHeaviestDeliverable();

            Assert.AreEqual(d.Weight, 750);
            Assert.AreEqual(d.ID, 35);
        }

        [TestMethod]
        public void TestFindHeaviestInATransportOf2WithEqualWeights()
        {// testing to find heaviest deliverable in a transport of size 1
            Transport t = new Transport();
            t.AddDeliverable(new Deliverable(22, 350, "Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(35, 350, "Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven"));

            Deliverable d = t.FindHeaviestDeliverable();

            Assert.AreEqual(d.Weight, 350);
            Assert.AreEqual(d.ID, 22);
        }

        [TestMethod]
        public void TestSortByAddress()
        {// testing the SortByAddress-method

            Transport t = new Transport();
            t.AddDeliverable(new Deliverable(1, 350, "Sven Kramer", "MainStreet", 33, "5688GE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(2, 700, "Adele", "Kerkstraat", 13, "5688DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(3, 360, "RedNex", "AAstraat", 166, "5688BX", "Amsterdam"));
            t.AddDeliverable(new Deliverable(4, 360, "Bruno Mars", "Kerkstraat", 39, "5688DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(5, 500, "Sven Kramer", "MainStreet", 33, "5688GE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(6, 950, "Irene Wust", "Kerkstraat", 20, "5693DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(7, 750, "Naomi van As", "MainStreet", 33, "5688GE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(8, 950, "Mr. Blue", "Zaragossastraat", 41, "5688DH", "Veldhoven"));
            t.AddDeliverable(new Deliverable(9, 100, "Bruno Mars", "Kerkstraat", 39, "5688DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(11, 60, "Anouk", "Kerkstraat", 10, "5693DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(12, 30, "Anouk", "Kerkstraat", 10, "5693DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(10, 40, "Anouk", "Kerkstraat", 10, "5693DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(13, 200, "Anouk", "Kerkstraat", 10, "5693DE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(14, 250, "Naomi van As", "MainStreet", 33, "5688GE", "Eindhoven"));
            t.AddDeliverable(new Deliverable(15, 600, "Irene Wust", "Kerkstraat", 20, "5693DE", "Eindhoven"));

            t.SortByAddress();

            Assert.AreEqual(t.Deliverables.Count, 15);
            int[] expectedIDs = {3, 10, 11, 12, 13, 2, 6, 15, 4, 9, 1, 5, 7, 14, 8};
            for (int i = 0; i < 15; i++)
            { Assert.AreEqual(expectedIDs[i], t.Deliverables[i].ID); }
        }

    }
}
