using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public abstract class AbstractClass
	{
		public string Name { get; set; }

		public AbstractClass(string name)
		{
			Name = name;
		}



		public abstract double CalculateArea();
	}

	public abstract class AbstractPolygon : AbstractClass
	{
		public AbstractPolygon(string name) : base(name)
		{
		}
	}



}
