using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class DateTimeVariable
    {
        public static void Run()
        {
            DateTime today = DateTime.Today;

            DateTime appropriateDateTime = DateTime.UtcNow;

            DateTime birthDay = DateTime.Parse("6/11/1998");
            DateTime birthDay2 = DateTime.ParseExact("6/11/1988", "d/M/yyyy", CultureInfo.InvariantCulture);


            Console.WriteLine(birthDay.ToString());
            Console.WriteLine(birthDay2);
            Console.WriteLine(today);
        }
    }
}
