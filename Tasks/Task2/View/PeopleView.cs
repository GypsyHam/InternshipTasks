using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Controllers;
using Task2.ViewModel;

namespace Task2.View
{
    public class PeopleView
    {
        public PeopleView() { }

        private PeopleModel model;

        public PeopleView(PeopleModel model)
        {
            this.model = model;
            // Set up UI components to display the list of people
        }

        public void UpdateView()
        {
            // Update UI to reflect changes in the model's PeopleList
        }
    }
}
