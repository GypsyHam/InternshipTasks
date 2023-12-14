using System.Threading.Tasks;

namespace Task1
{
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        int _tmrDuration = 0;
        int _tmrInterval = 0;
        int _timeRemaining = 0;
        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            decRemainingDuration();
            if (_timeRemaining <= 0 )
            {
                tmrCountDown.Stop();
                toggleInputs(true);
            }
        }

        private async void whileTimer()
        {
            while(_timeRemaining > 0)
            {
                decRemainingDuration();
                await Task.Delay(1000);
            }

            toggleInputs(true);


        }

        private void toggleInputs(bool enableDisable)
        {
            numDuration.Enabled = enableDisable;
            numInterval.Enabled = enableDisable;
            btnTimerStart.Enabled = enableDisable;
            gbxCounterMode.Enabled = enableDisable;
        }

        private void Task1Form_Load(object sender, EventArgs e)
        {
        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            _tmrDuration = _timeRemaining = (int)numDuration.Value;
            _tmrInterval = (int)numInterval.Value;
            toggleInputs(false);

            if(radTimer.Checked)
            {
                tmrCountDown.Start();
            }
            else
            {
                whileTimer();
            }
        }

        private void decRemainingDuration()
        {
            _timeRemaining -= _tmrInterval;
            lblTimeValue.Text = _timeRemaining.ToString() + " s";
        }

        private void numDuration_ValueChanged(object sender, EventArgs e)
        {
            lblTimeValue.Text = numDuration.Value.ToString() + " s";
        }
    }
}