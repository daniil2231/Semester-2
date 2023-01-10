using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemAssignment
{
    public class Student : Person
    {
        private int nrOfECs;

        public Student(int age, string name, int pcn, int yearsAtSchool, int ECs) : base(age, name, pcn, yearsAtSchool)
        {
            this.nrOfECs = ECs;
        }

        public override string ToString()
        {
            return $"STUDENT Name: {this.name}; PCN: {this.pcn}; Age: {this.age}; Years at school: {this.yearsAtSchool}; ECs: {this.nrOfECs}";
        }

        public void AddECs(int n)
        {
            nrOfECs += n;
        }

        public override void StartAnotherSchoolyear()
        {
            yearsAtSchool++;
        }
    }
}
