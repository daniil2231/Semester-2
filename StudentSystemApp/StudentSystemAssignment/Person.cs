using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemAssignment
{
    public abstract class Person
    {
        protected int age;
        protected string name;
        protected int pcn;
        protected int yearsAtSchool;

        public int Pcn
        {
            get { return this.pcn; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public Person(int age, string name, int pcn, int yearsAtSchool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
        }

        public void CelebrateBirthday()
        {
            this.age++;
        }

        public abstract void StartAnotherSchoolyear();
    }
}
