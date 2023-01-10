using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DeliverablesApp.logic
{
    public class Transport
    {
        private List<Deliverable> myDeliverables;

        public Transport()
        {
            this.myDeliverables = new List<Deliverable>();
        }

        public List<Deliverable> Deliverables { get { return this.myDeliverables; } }

        public void AddDeliverable(Deliverable d)
        {
            if (FindDeliverable(d.ID) == null)
            {
                myDeliverables.Add(d);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public Deliverable FindDeliverable(int id)
        {
            foreach (Deliverable d in this.myDeliverables)
            {
                if (d.ID == id)
                {
                    return d;
                }
            }
            return null;
        }

        public Deliverable FindHeaviestDeliverable()
        {
            if (this.myDeliverables.Count == 0)
                throw new Exception("There is no heaviest deliverable in an empty transport!");

            Deliverable heaviest = this.myDeliverables[0];

            foreach (Deliverable d in this.myDeliverables)
                if (d.Weight > heaviest.Weight)
                    heaviest = d;

            return heaviest;
        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by cityname, then by street; then by increasing house-number".
        /// So elements with the same cityname, but a different street, are sorted alfabetically by street.
        /// Elements with the same city and street, are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            // Solution 1)
            // Method 'Sort' can be used in conjunction with IComparable implementation
            // in Deliverable class.
            // this.Deliverables.Sort();

            // Solution 2) Simpler solution using method 'OrderBy'
            this.myDeliverables = this.myDeliverables.OrderBy(d => d.City)
                .ThenBy(d => d.Street)
                .ThenBy(d => d.Housenumber)
                .ThenBy(d => d.ID)
                .ToList();
        }

    }
}
