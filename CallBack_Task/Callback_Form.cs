using Callback_Task;

namespace CallBack_Task
{
    public partial class Callback_Form : Form
    {
        public Callback_Form()
        {
            InitializeComponent();
        }

        private void btnSubEvent_Click(object sender, EventArgs e)
        {
            HandleSimpleMessage(sender, new SimpleEventArgs("Test"));
        }

        private async void HandleSimpleMessage(object sender, SimpleEventArgs e)
        {
            // Process the simple message asynchronously
            await Task.Run(() => Console.WriteLine($"Received simple message: {e.Message}"));
        }


    }
}
