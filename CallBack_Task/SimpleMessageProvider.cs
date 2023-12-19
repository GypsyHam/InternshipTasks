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
        private volatile bool _timerRunning = true; // Use volatile for thread safety

        private static readonly SimpleMessageProvider instance = new SimpleMessageProvider();
        static SimpleMessageProvider() { }
        public static SimpleMessageProvider Instance { get {  return instance; } }

        public SimpleMessageProvider()
        {
            SetupTimer();
        }

        public bool IsTimerRunning
        {
            get { return _timerRunning; }
        }

        public void TimerToggle()
        {
            if (!_timerRunning)
            {
                StartTimer();
            }
            else
            {
                StopTimer();
            }
        }

        private void SetupTimer()
        {
            // Set up your timer logic here
            _timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

        public void StartTimer()
        {
            _timerRunning = true;
            SetupTimer();
        }

        public void StopTimer()
        {
            _timerRunning = false;
            _timer?.Change(Timeout.Infinite, Timeout.Infinite); // Stop the timer
        }

        private void TimerCallback(object state)
        {
            // This is a placeholder; implement your logic to send messages to subscribers
            DateTime currentDateTime = DateTime.Now;
            SimpleEventArgs args = new SimpleEventArgs(currentDateTime.ToString());

            OnSimpleMessageEvent(args);

            string evenOdd = (currentDateTime.Second % 2 == 0) ? "Even" : "Odd";
            bool isEven = (currentDateTime.Second % 2 == 0);
            string message = currentDateTime.ToString("mm:HH") + " " + evenOdd;

            OnKeyEvent(evenOdd);
        }

        public void Subscribe(string key, Func<SimpleEventArgs, Task> subscriber)
        {
            _simpleSubscribers.AddOrUpdate(
                key,
                _ => new ConcurrentHashSet<Func<SimpleEventArgs, Task>>(new List<Func<SimpleEventArgs, Task>> { subscriber }),
                (_, set) =>
                {
                    set.Add(subscriber);
                    return set;
                });
        }

        public void Unsubscribe(string key)
        {
            _simpleSubscribers.TryRemove(key, out _);
        }

        protected virtual void OnSimpleMessageEvent(SimpleEventArgs e)
        {
            SimpleMessageEvent?.Invoke(this, e);

            // Notify simple subscribers
            //foreach (var subscriberList in _simpleSubscribers.Values)
            //{
            //    foreach (var subscriber in subscriberList)
            //    {
            //        _ = subscriber.Invoke(e);
            //    }
            //}
        }

        protected virtual void OnKeyEvent(string key)
        {
            SimpleEventArgs e = new SimpleEventArgs(key);
            if (_simpleSubscribers.TryGetValue(key, out var subscribers))
            {
                foreach (var subscriber in subscribers)
                {
                    subscriber.Invoke(e);
                }
            }
        }

    }
}
