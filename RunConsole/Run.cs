using SecondApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;
using InterfacesApp;

namespace RunConsole
{
	public class Run
	{
		public static void Main()
		{
			/*
			Shapes curve = new Curve("Curve");
			Shapes polygon = new Polygon("Polygon");
			Shapes ellipsis = new Ellipsis(4, 5);
			Console.WriteLine($"{curve.Name} are : {curve.CalculateArea()}");
			Console.WriteLine($"{polygon.Name} are : {polygon.CalculateArea()}");
			Console.WriteLine($"{ellipsis.Name} are : {ellipsis.CalculateArea()}");
			Console.WriteLine($"{ellipsis.Name} are : {((Ellipsis)ellipsis).CalculateArea()}");
			*/




			/******
			 * Inheritance
			virtualShapes curve = new VirtualCurve("Curve");
			virtualShapes polygon = new VirtualPolygon("Polygon");
			virtualShapes ellipsis = new VirtualEllipsis(4, 5);
			Console.WriteLine($"{curve.Name} are : {curve.CalculateArea()}");
			Console.WriteLine($"{polygon.Name} are : {polygon.CalculateArea()}");
			Console.WriteLine($"{ellipsis.Name} are : {ellipsis.CalculateArea()}");
			Console.WriteLine($"{ellipsis.Name} are : {((VirtualEllipsis) ellipsis).CalculateArea()}");
			*/


			/*
			 * Interfaces
			 */
			TextLogger textLogger = new();
			JsonLogger jsonLogger = new();

			jsonLogger.IsEnabled = true;
			textLogger.IsEnabled = true;

			textLogger.Log();
			jsonLogger.Log();

			//Another example
			ILogger tLogger = new TextLogger();
			ILogger jLogger = new JsonLogger();

			jLogger.IsEnabled = true;
			tLogger.IsEnabled = true;
			jLogger.Log();
			tLogger.Log();

			List<ILogger> loggers = new List<ILogger>
			{
				new TextLogger
				{
					IsEnabled = true
				},

				new JsonLogger{
					IsEnabled = true
				}
			};

			foreach (var log in loggers)
			{
				log.Log();
			}
		}
	}
}
