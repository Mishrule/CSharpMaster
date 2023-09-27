namespace InterfacesApp
{
	public class InterfaceDemo
	{

	}

	public class TextLogger : ILogger
	{
		private bool _isEnabled;
		public bool IsEnabled
		{
			get { return _isEnabled;}
			set { _isEnabled = value; }
		}
		public void Log()
		{
			if (IsEnabled)
			{
				Console.WriteLine("Log from text file");
			}
		}
	}


	public class JsonLogger : ILogger
	{
		private bool _isEnabled;

		public bool IsEnabled
		{
			get { return _isEnabled; }
			set { _isEnabled = value; }
		}

		public void Log()
		{
			if (IsEnabled)
			{
				Console.WriteLine("Log from Json file");
			}
		}
	}

	public interface ILogger
	{
		bool IsEnabled { get; set; }
		void Log();
	}
}