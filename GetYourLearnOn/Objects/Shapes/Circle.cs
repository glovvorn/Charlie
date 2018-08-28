using GetYourLearnOn.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOn.Objects.Shapes
{
	class Circle: IShape
	{
		#region properties

		private static string name;

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public double Radius
		{
			get;
			set;
		}

		public double Diameter => 2 * Radius; // shorthand

		public double Circumference => (3.14 * Radius);

		#endregion properties

		#region contructors
		#endregion contructors

		#region public methods

		public double CalculateArea()
		{
			return 3.14 * Radius * Radius;
		}

		#endregion public methods

		#region private methods
		#endregion private methods
	}
}
