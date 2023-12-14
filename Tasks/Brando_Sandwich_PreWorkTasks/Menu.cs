using Task1;
using Task2;
using Task3;

namespace Brando_Sandwich_PreWorkTasks
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        Task1Form task1Form = new Task1Form();
        Task2Form task2Form = new Task2Form();
        Task3Form task3Form = new Task3Form();

        private void btnMenuTask1_Click(object sender, EventArgs e)
        {
            task1Form.Show();
        }

        private void btnMenuTask2_Click(object sender, EventArgs e)
        {
            task2Form.Show();
        }

        private void btnMenuTask3_Click(object sender, EventArgs e)
        {
            task3Form.Show();
        }
    }
}