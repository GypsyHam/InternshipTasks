using Callback_Task;

namespace CallBack_Task
{
    public partial class Callback_Form : Form
    {
        public Callback_Form()
        {
            InitializeComponent();
            GetTimerStatusForPanel();
        }

        SimpleMessageProvider simpleMessageProvider = SimpleMessageProvider.Instance;

        private void btnSubEvent_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Subscribe("AllEvents", HandleSimpleMessage);
        }

        async Task HandleSimpleMessage(SimpleEventArgs e)
        {
            // Process the simple message asynchronously
            Console.WriteLine($"Received simple message: {e.Message}");
            // Update UI element on the UI thread
            if (rtxtEvent.InvokeRequired)
            {
                rtxtEvent.Invoke(new Action(() => rtxtEvent.Text += "\n" + e.Message));
            }
            else
            {
                rtxtEvent.Text += e.Message + "\n";
            }
        }

        private void btnUnSubEvent_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Unsubscribe("AllEvents");
        }

        
        private void btnTimerToggle_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.TimerToggle();
            GetTimerStatusForPanel();
        }

        private void GetTimerStatusForPanel()
        {
            pnlTimerStatus.BackColor = simpleMessageProvider.IsTimerRunning ? Color.Green : Color.Red;
        }


    }
}
