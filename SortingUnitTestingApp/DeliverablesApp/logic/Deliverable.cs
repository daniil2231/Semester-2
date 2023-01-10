using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliverablesApp.logic
{

    public class Deliverable: IComparable<Deliverable>
    {
        private int id;    //the unique id of a deliverable
        private int weight; //the weight (in grams) of this deliverable

        //the next fields are the buyers name, street, housenumber, postal code and city
        private String name;
        private String street; 
        private int housenumber; 
        private String postalcode;
        private String city;

        public Deliverable(int id, int weight, String name, String street, int housenumber, String postalcode, String city)
        {
            this.id = id;
            this.weight = weight;
                     this.name = name;
            this.street = street;
            this.housenumber = housenumber;
            this.postalcode = postalcode;
            this.city = city;
        }

        public int ID { get { return this.id; } }
        public int Weight { get { return this.weight; } }

        public String Name { get { return this.name; } }
        public String Street { get { return this.street; } }
        public int Housenumber { get { return this.housenumber; } }
        public String Postalcode { get { return this.postalcode; } }
        public String City { get { return this.city; } }

        public int CompareTo(Deliverable other)
        {
            int cityComparison = this.City.CompareTo(other.City);
            if (cityComparison != 0)
            {
                return cityComparison;
            }

            int streetComparison = this.Street.CompareTo(other.Street);
            if (streetComparison != 0)
            {
                return streetComparison;
            }

            int numberComparison = this.Housenumber.CompareTo(other.Housenumber);
            if (numberComparison != 0)
            {
                return numberComparison;
            }

            int idComparison = this.ID.CompareTo(other.ID);
            return idComparison;
        }

        public override string ToString()
        {
            return "Id: " + Convert.ToString(this.id) + ", weight: " + Convert.ToString(this.weight) + ", should be delivered at: " +
                this.name + " - " + this.street + "  " + this.housenumber + " - " + this.postalcode + "  " + this.city;
        }

    }
}
