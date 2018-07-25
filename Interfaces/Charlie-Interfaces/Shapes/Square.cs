using System;
using System.Collections.Generic;
using System.Text;

namespace Charlie.Interfaces.Shapes
{
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public double BorderLength => SideLength * 4;

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
