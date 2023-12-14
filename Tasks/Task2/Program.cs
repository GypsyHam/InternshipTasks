using Task2.Controllers;
using Task2.View;
using Task2.ViewModel;

namespace Task2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create instances of the model, view, and controller
            PeopleModel model = new PeopleModel();
            PeopleView view = new PeopleView(model);
            PeopleController controller = new PeopleController(model, view);

            controller.GetFamilyFromFile(@"..\..\..\Data\GenericFamily.json");

            controller.AddGenericPeople();


            controller.GetPersonById(3);

            Application.Run(new Task2Form());
        }
    }
}