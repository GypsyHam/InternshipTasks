using log4net;
using log4net.Repository;
using System.Reflection;

namespace Callback_Task
{
    public interface ILogger
    {
        public void LogInfo(string message);
        public void LogDebug(string message);
        public void LogWarning(string message);
        public void LogError(string message, Exception ex = null);
        public void LogFatal(string message, Exception ex = null);
    }

    public sealed class Logger : ILogger
    {
        #region Singleton Instantiation https://csharpindepth.com/articles/singleton version 4

        private static readonly Logger instance = new Logger();

        private ILog _logger = LogManager.GetLogger("root");

        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static Logger() { }

        public static Logger Instance
        {
            get { return instance; }
        }

        #endregion

        private Logger()
        {
            ILoggerRepository repository = LogManager.GetRepository(Assembly.GetCallingAssembly());

            var fileInfo = new FileInfo(@"log4net.config");

            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
        }

        public void LogDebug(string message)
        {
            try
            {
                _logger.Debug(message);
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogInfo(string message)
        {
            try
            {
                _logger.Info(message);
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogWarning(string message)
        {
            try
            {
                _logger.Warn(message);
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogError(string message, Exception ex = null)
        {
            try
            {
                if (ex != null)
                {
                    _logger.Error(message, ex);
                }
                else
                {
                    _logger.Error(message);
                }
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogFatal(string message, Exception ex = null)
        {
            try
            {
                if (ex != null)
                {
                    _logger.Fatal(message, ex);
                }
                else
                {
                    _logger.Fatal(message);
                }
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }
    }

    public sealed class LoggerAsync : ILogger
    {
        #region Singleton Instantiation https://csharpindepth.com/articles/singleton version 4

        private static readonly LoggerAsync instance = new LoggerAsync();

        private ILog _logger = LogManager.GetLogger("root");

        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static LoggerAsync() { }

        public static LoggerAsync Instance
        {
            get { return instance; }
        }

        #endregion

        private LoggerAsync()
        {
            ILoggerRepository repository = LogManager.GetRepository(Assembly.GetCallingAssembly());

            var fileInfo = new FileInfo(@"log4net.config");

            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
        }

        public void LogDebug(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Debug(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogInfo(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Info(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogWarning(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Warn(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogError(string message, Exception ex = null)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Error(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogFatal(string message, Exception ex = null)
        {
            Task.Run(() =>
            {
                try
                {
                    if (ex != null)
                    {
                        _logger.Fatal(message, ex);
                    }
                    else
                    {
                        _logger.Fatal(message);
                    }
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }
    }
}
