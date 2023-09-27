using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class VirtualClass
    {
        
    }

    public class virtualShapes
    {
        public string Name { get; set; }

        public virtualShapes(string name)
        {
            Name = name;
        }



        public virtual double CalculateArea()
        {
            return double.NaN;
        }
    }


    public class VirtualPolygon : virtualShapes
    {
        public VirtualPolygon(string name) : base(name)
        {
        }
    }

    public class VirtualCurve : virtualShapes
    {
        public VirtualCurve(string name) : base(name)
        {
        }
    }

    public class VirtualEllipsis : VirtualCurve
    {
        public double MinorRadius { get; set; }
        public double MajorRadius { get; set; }

        public VirtualEllipsis(double minorRadius, double majorRadius) : base("Ellipse")
        {
            MinorRadius = minorRadius;
            MajorRadius = majorRadius;
        }

        public VirtualEllipsis(string name, double minorRadius, double majorRadius) : base(name)
        {
            MinorRadius = minorRadius;
            MajorRadius = majorRadius;
        }

        public virtual double CalculateArea()
        {
            return Math.PI * MinorRadius * MajorRadius;
        }
    }




}
