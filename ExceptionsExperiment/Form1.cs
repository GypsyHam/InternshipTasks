using System.CodeDom;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ExceptionsExperiment
{
    public partial class Form1 : Form
    {
        System.Threading.Timer threadingTimer;
        public Form1()
        {
            InitializeComponent();

            threadingTimer = new System.Threading.Timer(ThreadingTimer_Tick, null, Timeout.Infinite, Timeout.Infinite);
        }

        bool threadingTimerToggle(System.Threading.Timer timer, bool startStop)
        {
            if (startStop)
            {
                timer.Change(1000, Timeout.Infinite);
                startStop = false;
            }
            else
            {
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                startStop = true;
            }

            return startStop;

        }

        private void ThreadingTimer_Tick(object state)
        {
            NonImplementedMethodWithTryCatch(); // NO LIKEY LogError \_(o.o)_/
        }

        void LogError(Exception ex)
        {
            string skipLine = rtxtLog.Text == "" ? "" : "\n";
            string time = DateTime.Now.ToString("HH:mm:ss");
            // StackOverflow starts here:
            // Get stack trace for the exception with source file information
            var st = new StackTrace(ex, true);
            // Get the top stack frame
            var frame = st.GetFrame(0);
            // Get the line number from the stack frame
            var line = frame.GetFileLineNumber();
            // StackOverflow ends here:
            rtxtLog.Text += string.Format(skipLine + time + " - Encountered an error at line {0} with the exception: {1}", line, ex);
            rtxtLog.Text += "\n======================================================";
        }

        private void btnDirectException_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        private void btnMethodException_Click(object sender, EventArgs e) // doesn't catch NonImplementedMethodWithTryCatch error.
        {
            try
            {
                NonImplementedMethodWithTryCatch();
            }
            finally
            {
                try
                {
                    throw new Exception();
                }catch(Exception ex)
                {
                    LogError(ex);
                }
            }
        }

        void NonImplementedMethodWithTryCatch()
        {
            try
            {
                throw new NotImplementedException("Low Level Not Implemented.");
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        void CallingNonImplementedThatHasTryCatch()
        {
            NonImplementedMethodWithTryCatch();
        }

        async Task CallingNonImplementedThatHasTryCatchAsync()
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

        private async Task NonImplementedAsync()
        {
            // Simulate an exception
            LoopToCallMethodInMethodWithTryCatch();
        }

        void WrappingNonImplementedMethodInCatch()
        {
            try
            {
                NonImplemented();
            }
            catch (Exception ex)
            {

                LogError(ex);
            }
        }

        private void btnWrapMethodInTryCatch_Click(object sender, EventArgs e)
        {
            WrappingNonImplementedMethodInCatch(); // fails at line 114 (where the method fails and not the wrapper)
        }

        private void LoopToCallMethodInMethodWithTryCatch()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    CallingNonImplementedThatHasTryCatch(); // fails on line 89
                }
            }
        }

        private async Task LoopToCallIntMethodInMethodWithTryCatchTestAsync()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                    {
                        await CallingNonImplementedThatHasTryCatchAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        private void btnLoopM2MWithTryCatch_Click(object sender, EventArgs e)
        {
            LoopToCallMethodInMethodWithTryCatch(); // error on line 89 (lowest level)
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
        {  // fails on line 114
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    NonImplemented();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
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

                LogError(ex);
            }
        }

        private void btnTryWithinTry_Click(object sender, EventArgs e)
        {
            TryWithinTry(); // deepest try breaks first. -- line 89
        }

        private void btnAsyncTaskLoopTest_Click(object sender, EventArgs e)
        {
            LoopToCallIntMethodInMethodWithTryCatchTestAsync(); // line 89
        }

        private void btnAsyncVoidTest_Click(object sender, EventArgs e)
        {
            AsyncVoidEventTest();
        }

        private async void AsyncVoidEventTest()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    await NonImplementedAsync();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        async void DivZero()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                DivZero();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        bool startTimer = true;
        private void btnFormTimerStart_Click(object sender, EventArgs e)
        {
            if (startTimer)
            {
                testTimer.Start();
            }
            else
            {
                testTimer.Stop();
            }
        }

        private void btnAsyncNoCatch_Click(object sender, EventArgs e)
        {
            try
            {
                AsyncVoidEventTestNoCatch();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }
        private async void AsyncVoidEventTestNoCatch()
        {
            for (int i = 0; i < 5; i++)
            {
                throw new Exception();
            }
        }

        bool threadTimerStart = true;
        private void btnThreadTimer_Click(object sender, EventArgs e)
        {
            threadTimerStart = threadingTimerToggle(threadingTimer, threadTimerStart);
        }
    }
}
