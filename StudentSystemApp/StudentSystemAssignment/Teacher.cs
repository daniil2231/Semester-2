using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemAssignment
{
    public class Teacher : Person
    {
        private JobPosition position;
        private double salary;

        public Teacher(int age, string name, int pcn, int yearsAtSchool, double salary, JobPosition position) : base(age, name, pcn, yearsAtSchool)
        {
            this.salary = salary;
            this.position = position;
        }

        public override string ToString()
        {
            return $"TEACHER Name: {this.name}; PCN: {this.pcn}; Age: {this.age}; Years at school: {this.yearsAtSchool}; Salary: {this.salary:f2}; Position: {this.position}";
        }

        public void MakePromotion()
        {
            int positionEnumIndex = (int)Enum.Parse(typeof(JobPosition), $"{position}");

            if (positionEnumIndex < 5)
            {
                positionEnumIndex++;
                position = (JobPosition)positionEnumIndex;
            }
        }

        public override void StartAnotherSchoolyear()
        {
            yearsAtSchool++;

            if (yearsAtSchool % 3 == 0)
            {
                salary = salary + (salary / 10);
            }
        }
    }
}
