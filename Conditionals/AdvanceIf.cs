using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class AdvanceIf
    {
        public static void Run()
        {
            Console.WriteLine("What is your first name: ");
            string firstName = Console.ReadLine();

           

            if (firstName.ToLower() == "hello")
            {
                Console.WriteLine("What is your last name: ");
                string lastName = Console.ReadLine();
            }
        }
    }
}
