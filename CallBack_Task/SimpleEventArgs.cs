namespace Callback_Task
{
    public class SimpleEventArgs : EventArgs
    {
        public string Message { get; }

        public SimpleEventArgs(string message)
        {
            Message = message;
        }
    }
}
