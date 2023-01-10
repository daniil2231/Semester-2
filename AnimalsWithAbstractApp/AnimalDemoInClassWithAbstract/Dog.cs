using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDemoInClassWithAbstract
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Dog: {this.name}";
        }

        public override string Speak()
        {
            return "Bark";
        }
    }
}
