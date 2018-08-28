using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOn.Interfaces.Shapes
{
	interface IShape
	{
		// An interface is a contract and contains only the signatures of methods, properties, events or indexers. 
		// A class or struct that implements the interface must implement the members of the interface that are 
		// specified in the interface definition.
		double CalculateArea();
	}
}
