﻿using log4net;
using log4net.Core;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback_Task
{
    public class CustomCallbackLogger : ILogger
    {
        private readonly ILog _log;
        public string Name { get; }

        public CustomCallbackLogger(string categoryName)
        {
            _log = LogManager.GetLogger(categoryName);
        }

        public ILoggerRepository Repository { get; }

        public void Log(LoggingEvent logEvent)
        {
            try
            {
                _log.Logger.Log(logEvent);
            }catch (Exception)
            {

            }
        }

        public void Log(Type callerStackBoundaryDeclaringType, Level level, object message, Exception exception)
        {
            try
            {
                if (IsEnabledFor(level))
                {
                    _log.Logger.Log(callerStackBoundaryDeclaringType, level, message.ToString(), exception);
                }
            }catch (Exception)
            {
                
            }
        }

        public bool IsEnabledFor(Level level)
        {
            bool isItThough = _log.Logger.IsEnabledFor(level);
            return isItThough;
        }
    }
}
