using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Ellipsis: Curve
	{
		public double MinorRadius { get; set; }
		public double MajorRadius { get; set; }
		public Ellipsis(double minorRadius, double majorRadius) : base("Ellipse")
		{
			MinorRadius = minorRadius;
			MajorRadius = majorRadius;
		}

		public Ellipsis(string name, double minorRadius, double majorRadius):base(name)
		{
			MinorRadius = minorRadius;
			MajorRadius = majorRadius;
		}

		public double CalculateArea()
		{
			return Math.PI * MinorRadius * MajorRadius;
		}
	}
}
