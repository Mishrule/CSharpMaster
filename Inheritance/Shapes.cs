using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Shapes
    {
        public string Name { get; set; }
        public Shapes(string name)
        {
            Name = name;
        }



        public double CalculateArea()
        {
            return double.NaN;
        }
    }
}
