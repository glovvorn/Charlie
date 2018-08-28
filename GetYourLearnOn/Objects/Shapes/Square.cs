using GetYourLearnOn.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOn.Objects.Shapes
{
	class Square: IShape
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

		public double SideLength { get; set; }

		public double BorderLength => SideLength * 4;

		#endregion properties

		#region contructors
		#endregion contructors

		#region public methods

		public double CalculateArea()
		{
			return SideLength * SideLength;
		}

		#endregion public methods

		#region private methods
		#endregion private methods
	}
}
