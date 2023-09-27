using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.LogChallenges.CongreteLoggers
{
    public class JsonLogger:IBaseLogger
    {
        public void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Info(string message)
        {
           Log(message, LogLevel.INFORMATION);
        }

        public void Log(string message, LogLevel logLevel)
        {
            string fullPattern = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
            LogEntry logEntry = new LogEntry
            {
                LogDateTime = DateTime.UtcNow.ToString(fullPattern),
                LogType = LogLevel.INFORMATION,
            };
        }

        public void AppendToLogFile(string logMessage)
        {
            throw new NotImplementedException();
        }
    }
}
