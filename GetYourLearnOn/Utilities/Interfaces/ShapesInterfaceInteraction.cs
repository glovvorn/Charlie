using GetYourLearnOn.Interfaces.Shapes;
using GetYourLearnOn.Objects.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOn.Utilities.Interfaces
{
	public class ShapesInterfaceInteraction
	{
		#region properties

		private static int menuChoice = -1;
		private int radius;
		private string shapeName;
		private List<IShape> Shapes = new List<IShape>();
		private List<Circle> Circles = new List<Circle>();
		private List<Square> Squares = new List<Square>();

		#endregion properties

		#region contructors

		public ShapesInterfaceInteraction()
		{
			Console.Clear();
		}
		#endregion contructors

		#region public methods

		public void DisplayInterfaceMenu()
		{
			do
			{
				printInterfaceMenu();

				int.TryParse(Console.ReadLine(), out menuChoice);

				switch (menuChoice)
				{
					case 0:
						// go back to the main
						Program.DisplayMainMenu();
					break;

					case 1:
						buildACircle();
					break;

					case 2:
					break;

					case 3:
					break;

					default:
						Console.WriteLine("Oops, that is not a valid entry. Please try again.");
					break;
				}

			} while (menuChoice == -1);

			if (menuChoice != 0)
			{
				Console.ReadLine();
			}
		}

		#endregion public methods

		#region private methods

		private void printInterfaceMenu()
		{
			Console.WriteLine("What would you like to do?:");
			Console.WriteLine();
			Console.WriteLine("0. Go Back");
			Console.WriteLine("1. Build a Circle");
			Console.WriteLine("2. Build a square");
			Console.WriteLine();
		}

		private void buildACircle()
		{
			shapeName = null;
			string tempRadius = string.Empty;

			Console.WriteLine("Enter the name of the circle:");
			shapeName = Console.ReadLine();
			Console.WriteLine("Enter the radius of the circle:");
			tempRadius = Console.ReadLine();

			if (!String.IsNullOrEmpty(shapeName) && int.TryParse(tempRadius, out radius))
			{
				Circle circle = new Circle()
				{
					Radius = radius,
					Name = shapeName
				};

				Shapes.Add(circle);
				calculateDataForShapes();
				DisplayInterfaceMenu();
			}
			else
			{
				Console.WriteLine("that is not a valid value, please try again");
				DisplayInterfaceMenu();
			}
		}


		private void calculateDataForShapes()
		{
			foreach (IShape shape in Shapes)
			{
				if (shape is Circle cr)
				{
					Console.WriteLine("------------------------------------------");
					Console.WriteLine(String.Format("Circle Name: {0}", cr.Name));
					Console.WriteLine(String.Format("Circle Radius: {0}", cr.Radius));
					Console.WriteLine(String.Format("Circle Diameter: {0}", cr.Diameter));
					Console.WriteLine(String.Format("Circle Circumference: {0}", cr.Circumference));
					Console.WriteLine(String.Format("Circle Area: {0}", shape.CalculateArea()));
					Console.WriteLine("------------------------------------------");

				}
				else if (shape is Square sq)
				{
					Console.WriteLine($"SideLength: {sq.SideLength}");
					Console.WriteLine("------------------------------------------");
					Console.WriteLine($"Square Name: { sq.Name }");
					Console.WriteLine($"Square Side Length: { sq.SideLength }");
					Console.WriteLine($"Square Border Length: { sq.BorderLength }");
					Console.WriteLine($"Square Area: {shape.CalculateArea()}");
					Console.WriteLine("------------------------------------------");
				}



				//Console.WriteLine(shape.CalculateArea());


			}
		}

		#endregion private methods
	}

}
