using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDemoInClassWithAbstract
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Cat: {this.name}";
        }

        public override string Speak()
        {
            return "Meow";
        }
    }
}
