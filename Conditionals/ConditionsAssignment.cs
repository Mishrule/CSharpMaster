using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class ConditionsAssignment
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a name");
            string getInput = GetInput();
            string getInformation = GetInformation(getInput);
            ProcessForSwitch(getInformation);
            ProcessForIf(getInformation);
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static string GetInformation(string userInformation)
        {
            return userInformation;
        }

        public static void ProcessForSwitch(string data)
        {
            switch (data)
            {
                case "tim" or "Tim" or "TIM":
                    Console.WriteLine($"Welcome Professor {GetInformation(data)}");
                    break;
                default:
                    Console.WriteLine($"{GetInformation(data)} you are a student");
                    break;
            }
        }

        public static void ProcessForIf(string data)
        {
            if (data.ToLower() == "tim")
            {
                Console.WriteLine($"Welcome Professor {GetInformation(data)}");
            }
            else
            {
                Console.WriteLine($"{GetInformation(data)} you are a student");
            }
        }
    }
}
