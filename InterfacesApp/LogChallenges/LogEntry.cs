using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.LogChallenges
{
	public class LogEntry
	{
		public string LogDateTime { get; set; }
		public LogLevel LogType { get; set; }
		public string LogMessage { get; set; }
	}
}
