using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.LogChallenges.CongreteLoggers
{
    public interface IBaseLogger
    {
        void Error(string message);
        void Info(string message);
        void Log(string message, LogLevel logLevel);
        void AppendToLogFile(string logMessage);
    }
}
