using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDemoInClassWithAbstract
{
    public abstract class Animal
    {
        protected string name;

        public string Name
        {
            get { return this.name; }
        }

        protected Animal(string name)
        {
            this.name = name;
        }

        public abstract string Speak();
    }
}
