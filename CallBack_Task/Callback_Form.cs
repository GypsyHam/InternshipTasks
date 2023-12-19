using Callback_Task;
using log4net.Config;

namespace CallBack_Task
{
    public partial class Callback_Form : Form
    {
        public Callback_Form()
        {
            InitializeComponent();
            UpdateUIByTimerStatus();
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        SimpleMessageProvider simpleMessageProvider = SimpleMessageProvider.Instance;


        private void HandleSimpleMessage(object? sender, SimpleEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
                // Process the simple message asynchronously
                log.Info($"Received simple message: {e.Message}");
                // Update UI element on the UI thread
                if (rtxtEvent.InvokeRequired)
                {
                    rtxtEvent.Invoke(new Action(() => rtxtEvent.Text += "\n" + message));
                }
                else
                {
                    rtxtEvent.Text += message + "\n";
                }
                pnlEventSub.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //throw;
            }
        }
        async Task HandleEvenMessage(SimpleEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
                // Process the even message asynchronously
                log.Info($"Received even message: {e.Message}");
                // Update UI element on the UI thread
                if (rtxtEvenCallback.InvokeRequired)
                {
                    rtxtEvenCallback.Invoke(new Action(() => rtxtEvenCallback.Text += "\n" + message));
                }
                else
                {
                    rtxtEvenCallback.Text += message + "\n";
                }
                pnlEvenSub.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        async Task HandleOddMessage(SimpleEventArgs e)
        {
            string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            // Process the odd message asynchronously
            log.Info($"Received odd message: {e.Message}");
            // Update UI element on the UI thread
            if (rtxtOddCallback.InvokeRequired)
            {
                rtxtOddCallback.Invoke(new Action(() => rtxtOddCallback.Text += "\n" + message));
            }
            else
            {
                rtxtOddCallback.Text += e.Message + "\n";
            }
            pnlOddSub.BackColor = Color.Green;
        }

        private void UpdateUIByTimerStatus()
        {
            pnlTimerStatus.BackColor = simpleMessageProvider.IsTimerRunning ? Color.Green : Color.Red;
            btnTimerToggle.Text = simpleMessageProvider.IsTimerRunning ? "Stop Timer" : "Start Timer";
        }


        private void btnTimerToggle_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.TimerToggle();
            UpdateUIByTimerStatus();
        }
        private void btnSubEvent_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.SimpleMessageEvent += HandleSimpleMessage;
        }

        private void btnUnSubEvent_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.SimpleMessageEvent -= HandleSimpleMessage;
        }

        private void btnSubEvenCallback_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Subscribe("Even", HandleEvenMessage);
        }

        private void btnSubOddCallback_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Subscribe("Odd", HandleOddMessage);
            
        }

        private void btnUnSubEvenCallback_Click(object sender, EventArgs e)
        {
            simpleMessageProvider.Unsubscribe("Even");
        }

        private void btnUnSubOddCallback_Click(object sender, EventArgs e)
        {

            simpleMessageProvider.Unsubscribe("Odd");
        }
    }
}
