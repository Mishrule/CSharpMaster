using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class NullVariables
    {
        public static void Run()
        {
            // null - lack of value

            //Haven't asked for the age yet
            int? age = null;
            bool? birthday = null;
            double? battingAverage = null;
            string firstName = null;

            //We have asked for the age now
            age = 0;
        }
    }
}
