using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDemoInClassWithAbstract
{
    public class AnimalAdministration
    {
        List<Animal> animals;

        public AnimalAdministration()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal a)
        {
            animals.Add(a);
        }

        public List<Animal> GetAnimals()
        {
            return this.animals;
        }
    }
}
