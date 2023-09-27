using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Circle:Ellipsis
	{
		public Circle(string name, double minorRadius, double majorRadius) : base(name, minorRadius, majorRadius)
		{
		}
	}
}
