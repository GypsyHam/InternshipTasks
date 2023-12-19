using Callback_Task;

namespace CallBack_Task
{
    public partial class Callback_Form : Form
    {
        public Callback_Form()
        {
            InitializeComponent();
            UpdateUIByTimerStatus();
        }

        SimpleMessageProvider simpleMessageProvider = SimpleMessageProvider.Instance;


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

        async Task HandleEvenMessage(SimpleEventArgs e)
        {
            // Process the simple message asynchronously
            Console.WriteLine($"Received even message: {e.Message}");
            // Update UI element on the UI thread
            if (rtxtEvenCallback.InvokeRequired)
            {
                rtxtEvenCallback.Invoke(new Action(() => rtxtEvenCallback.Text += "\n" + e.Message));
            }
            else
            {
                rtxtEvenCallback.Text += e.Message + "\n";
            }
        }

        async Task HandleOddMessage(SimpleEventArgs e)
        {
            // Process the simple message asynchronously
            Console.WriteLine($"Received odd message: {e.Message}");
            // Update UI element on the UI thread
            if (rtxtOddCallback.InvokeRequired)
            {
                rtxtOddCallback.Invoke(new Action(() => rtxtOddCallback.Text += "\n" + e.Message));
            }
            else
            {
                rtxtOddCallback.Text += e.Message + "\n";
            }
        }

        private void btnSubEvent_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Subscribe("Simple Event", HandleSimpleMessage);
            pnlEventSub.BackColor = Color.Green;
        }

        private void btnUnSubEvent_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Unsubscribe("Simple Event");
            pnlEventSub.BackColor = Color.Red;
        }


        private void btnTimerToggle_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.TimerToggle();
            UpdateUIByTimerStatus();
        }

        private void UpdateUIByTimerStatus()
        {
            pnlTimerStatus.BackColor = simpleMessageProvider.IsTimerRunning ? Color.Green : Color.Red;
            btnTimerToggle.Text = simpleMessageProvider.IsTimerRunning ? "Stop Timer" : "Start Timer";
        }

        private void btnSubEvenCallback_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Subscribe("Even", HandleEvenMessage);
            pnlEvenSub.BackColor = Color.Green;
        }

        private void btnSubOddCallback_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Subscribe("Odd", HandleOddMessage);
            pnlOddSub.BackColor = Color.Green;
        }
    }
}
