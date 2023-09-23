using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class BoolVariables
    {
        public static void Run()
        {
            //true or false

            bool isComplete = false;

            isComplete = !isComplete;

            Console.WriteLine(isComplete);
        }
    }
}
