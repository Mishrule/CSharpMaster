using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
	public class SecondApp
	{
		public static void Run()
		{
			//Welcome user To Application
			Console.WriteLine("Welcome to the Greeting Application");
			Console.WriteLine("This application was built by Mishrule");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine();

			//Ask for First Name
			Console.WriteLine("Please enter your first name");
			string firstName = Console.ReadLine();

			//Greet user by name
			Console.WriteLine($"Welcome: {firstName}");
			Console.WriteLine("Application Terminated Successfully");
			Console.ReadLine();
		}
	}
}
