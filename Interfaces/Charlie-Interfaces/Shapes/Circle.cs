using System;
using System.Collections.Generic;
using System.Text;

namespace Charlie.Interfaces.Shapes
{
    public class Circle : IShape
    {
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

        public double Radius { get; set; }

        public double Diameter => 2 * Radius;

        public double Circumference => (3.14 * Radius);

        public double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
