using Charlie.Interfaces;
using Charlie.Interfaces.Shapes;
using System;
using System.Collections.Generic;

namespace Charlie_Interfaces
{
    class Program
    {
        static List<IShape> Shapes = new List<IShape>();
        static List<Circle> Circles = new List<Circle>();
        static List<Square> Squares = new List<Square>();

        static void Main(string[] args)
        {
            Circle c = new Circle
            {
                Radius = 2
            };

            Circle c2 = new Circle
            {
                Radius = 2
            };

            c.Name = "Circle 1";
            c2.Name = "Circle 2";

            Square s = new Square
            {
                SideLength = 4
            };

            //Adult adult = new Adult();

            //adult.FirstName = "Charlie";
            //adult.LastName = "HSomething";

            //var fullName = adult.GetFullName();
            //var age = adult.GetAge();

            //SampleAbstractClass adult2 = new Adult
            //{
            //    FirstName = "Greg",
            //    LastName = "LSomething"
            //};

            //var fullName2 = adult2.GetFullName();
            //var age2 = adult2.GetAge();

            Shapes.Add(c);
            Shapes.Add(s);

            Circles.Add(c);
            //Circles.Add(s); //INVALID

            Squares.Add(s);
            //Squares.Add(c); //INVALID

            foreach (IShape shape in Shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                
                if (shape is Square sq)
                {
                    Console.WriteLine($"SideLength: {sq.SideLength}");
                }
            }
        }
    }
}
