using ConcurrentCollections;
using System.Collections.Concurrent;

namespace Callback_Task
{
    public class SimpleMessageProvider
    {
        public event EventHandler<SimpleEventArgs> SimpleMessageEvent;
        private ConcurrentDictionary<string, ConcurrentHashSet<Func<SimpleEventArgs, Task>>> _simpleSubscribers = new();
        private System.Threading.Timer _timer;
        private volatile bool _timerRunning = true; // Use volatile for thread safety (apparently)


        private static readonly SimpleMessageProvider instance = new SimpleMessageProvider();
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
            try
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
            catch (Exception)
            {

                //throw;
            }
        }

        private void SetupTimer()
        {
            try
            {
                _timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            }
            catch (Exception)
            {
                //throw;
            }
        }

        public void StartTimer()
        {
            try
            {
                _timerRunning = true;
                SetupTimer();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        public void StopTimer()
        {
            try
            {
                _timerRunning = false;
                _timer?.Change(Timeout.Infinite, Timeout.Infinite);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void TimerCallback(object state)
        {
            try
            {
                DateTime currentDateTime = DateTime.Now;
                SimpleEventArgs args = new SimpleEventArgs("Simple");

                OnSimpleMessageEvent(args);

                string evenOdd = (currentDateTime.Second % 2 == 0) ? "Even" : "Odd";

                OnKeyEvent(evenOdd);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        public void Subscribe(string key, Func<SimpleEventArgs, Task> subscriber)
        {
            try
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
            catch (Exception)
            {
                //throw;
            }
        }

        public void Unsubscribe(string key)
        {
            try
            {
                _simpleSubscribers.TryRemove(key, out _);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected virtual void OnSimpleMessageEvent(SimpleEventArgs e)
        {
            try
            {
                SimpleMessageEvent?.Invoke(this, e);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected virtual void OnKeyEvent(string key)
        {
            try
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
            catch (Exception)
            {
                //throw;
            }
        }

    }
}
