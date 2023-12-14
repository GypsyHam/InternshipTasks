using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.ViewModel
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Surname { get; set; }
        //public List<string>? MiddleNames { get; set; }
        //public int Age { get; set; }
        //public string Gender { get; set; }
        //public string Sex { get; set; }
        //public bool Alive { get; set; }
        public List<Person>? Parents { get; set; }
        public List<Person>? Children { get; set; }
        public List<Partner>? Partners { get; set; }

        public Person()
        {
            Parents = new List<Person>();
            Partners = new List<Partner>();
        }
    }

    public class Partner: Person
    {
        public bool IsMarriage { get; set; }

        public Partner(Person person, bool isMarriage)
        {
            IsMarriage = isMarriage;
        }
    }

    public class PeopleModel
    {
        public List<Person>  PeopleList { get; set; }

        public PeopleModel()
        {
            PeopleList = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            PeopleList.Add(person);
        }

        public Person GetPersonById(int id)
        {
            return PeopleList.FirstOrDefault(x => x.Id == id);

 
        }
    }
}
