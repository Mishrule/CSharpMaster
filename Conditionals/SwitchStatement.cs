using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class SwitchStatement
    {
        public static void Run()
        {
            Console.WriteLine("Enter a Name");
            string firstName = Console.ReadLine();
            int age = 43;

            switch (firstName.ToLower())
            {
                case "tm" or "jerry":
                    Console.WriteLine("Welcome my man");
                    break;
                case "tim":
                    Console.WriteLine($"Hello Professor {firstName}");
                    break;

                case "tom":
                    Console.WriteLine("Welcome my man");
                    break;

                default:
                    Console.WriteLine("nothing matched");
                    break;
            }


            switch (age)
            {
                case >= 0 and < 18:
                    Console.WriteLine("You are a child");
                    break;

                case >= 18 and < 66:
                    Console.WriteLine("You should have a job");
                    break;

                case >= 66:
                    Console.WriteLine("Hopefully you are retired or retiring soon.");
                    break;

                default:
                    Console.WriteLine("Age was not in an expected range. ");
                    break;
            }
        }
    }
}
