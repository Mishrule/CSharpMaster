using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.LogChallenges.CongreteLoggers
{
    public class TextLogger:IBaseLogger
    {
        private readonly string Separator = "--------------------------------";
        public void Error(string message)
        {
            
            Log(message, LogLevel.ERROR);
        }

        public void Info(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Log(string message, LogLevel logLevel)
        {
            string messageToLog = string.Empty;
            var stringBuilder = new StringBuilder();
            string fullPattern = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
            stringBuilder.AppendLine(DateTime.UtcNow.ToString(fullPattern));
            stringBuilder.AppendLine(logLevel.ToString());
            stringBuilder.AppendLine(message);
            stringBuilder.AppendLine(Separator);
            AppendToLogFile(stringBuilder.ToString());
        }

        public void AppendToLogFile(string logMessage)
        {
            File.AppendAllText("log.txt", logMessage);
        }
    }
}
