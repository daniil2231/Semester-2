using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemAssignment
{
    public class Administration
    {
        private List<Person> persons;

        public Administration()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public List<Person> CheckForPartialName(string partialName)
        {
            List<Person> persons = new List<Person>();

            foreach (Person person in GetPersons())
            {
                if (person.Name.Contains(partialName))
                {
                    persons.Add(person);
                }
            }
            return persons;
        }

        public Person GetPersonByPCN(int pcn)
        {
            foreach (Person person in GetPersons())
            {
                if (person.Pcn == pcn)
                {
                    return person;
                }
            }

            return null;
        }

        public List<Person> GetPersons()
        {
            return persons;
        }
    }
}
