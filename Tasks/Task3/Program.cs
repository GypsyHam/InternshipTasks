namespace Task3
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
            // Create an ExpressionModel object and then call calculateExpression
            Application.Run(new Task3Form());

            //(2 + (1 + 5)) * 7 - 6 = (2 + (1 + 5)) * 7 - 6 = (2 + (1 + 5)) * 7 - 6
        }
    }
}