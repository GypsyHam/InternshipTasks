using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Task2.View;
using Task2.ViewModel;
using Newtonsoft.Json;

namespace Task2.Controllers
{
    public class PeopleController
    {
        private PeopleModel _model;
        private PeopleView _view;

        public PeopleController(PeopleModel model, PeopleView view)
        {
            _model = model;
            _view = view;
        }

        public void AddPerson(Person person)
        {
            _model.AddPerson(person);
        }

        public Person GetPersonById(int id)
        {
            return _model.GetPersonById(id);
        }

        public void AddGenericPeople()
        {
            _model.AddPerson(new Person { Id = 1, Name = "Alice" });
            _model.AddPerson(new Person { Id = 2, Name = "Bob" });
            List<Person> parents = new List<Person>();
            parents.Add(_model.GetPersonById(1));
            parents.Add(_model.GetPersonById(2));
            _model.AddPerson(new Person { Id = 3, Name = "Kenny", Parents = parents });
        }

        public void GetFamilyFromFile(string filePath)
        {
            string jsonData = System.IO.File.ReadAllText(filePath);

            var data = JsonConvert.DeserializeObject<PeopleModel>(jsonData);
        }
    }
}
