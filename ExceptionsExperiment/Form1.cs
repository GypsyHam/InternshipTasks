namespace ExceptionsExperiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirectException_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMethodException_Click(object sender, EventArgs e)
        {
            NonImplementedMethodWithTryCatch();
        }

        void NonImplementedMethodWithTryCatch()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void CallingNonImplementedThatHasTryCatch()
        {
            NonImplementedMethodWithTryCatch();
        }

        private void btnM2MWithTry_Click(object sender, EventArgs e)
        {
            CallingNonImplementedThatHasTryCatch();
        }

        void NonImplemented()
        {
            throw new NotImplementedException();
        }

        void WrappingNonImplementedMethodInCatch()
        {
            try
            {
                NonImplemented();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnWrapMethodInTryCatch_Click(object sender, EventArgs e)
        {
            WrappingNonImplementedMethodInCatch();
        }

        private void LoopToCallMethodInMethodWithTryCatch()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    CallingNonImplementedThatHasTryCatch();
                }
            }
        }

        private void btnLoopM2MWithTryCatch_Click(object sender, EventArgs e)
        {
            LoopToCallMethodInMethodWithTryCatch();
        }

        private void btnLoopInsideLoopThatCallsMethodCallMethodTry_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    LoopToCallMethodInMethodWithTryCatch();
                }
            }
        }

        private void btnTryCatchFromLoopToMethod_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    NonImplemented();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void TryWithinTry()
        {
            try
            {
                NonImplementedMethodWithTryCatch();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTryWithinTry_Click(object sender, EventArgs e)
        {
            TryWithinTry(); // deepest try breaks first.
        }
    }
}
