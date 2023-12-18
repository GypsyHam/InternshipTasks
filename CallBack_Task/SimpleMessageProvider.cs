using ConcurrentCollections;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace Callback_Task
{
    public class SimpleMessageProvider
    {
        public event EventHandler<SimpleEventArgs> SimpleMessageEvent;
        private ConcurrentDictionary<string, ConcurrentHashSet<Func<SimpleEventArgs, Task>>> _simpleSubscribers = new();
        private System.Threading.Timer _timer;

        private static readonly SimpleMessageProvider instance = new SimpleMessageProvider();
        static SimpleMessageProvider() { }
        public static SimpleMessageProvider Instance { get {  return instance; } }     

        public SimpleMessageProvider()
        {
            SetupTimer();
        }
        private void SetupTimer()
        {
            // Set up your timer logic here
            _timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

        private void TimerCallback(object state)
        {
            // This is a placeholder; implement your logic to send messages to subscribers
            OnSimpleMessageEvent(new SimpleEventArgs("YourMessage"));
        }

        protected virtual void OnSimpleMessageEvent(SimpleEventArgs e)
        {
            SimpleMessageEvent?.Invoke(this, e);

            // Notify subscribers
            foreach (var subscriberList in _simpleSubscribers.Values)
            {
                foreach (var subscriber in subscriberList)
                {
                    _ = subscriber.Invoke(e);
                }
            }
        }

    }
}
