using GetYourLearnOn.Utilities.Helpers;
using GetYourLearnOn.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOn
{
	public class Program
	{
		#region properties

		private static int menuChoice = -1;

		#endregion properties

		#region Main

		static void Main(string[] args)
		{
			DisplayMainMenu();
		}

		#endregion Main


		#region public methods

		public static void DisplayMainMenu()
		{

			do
			{
				PrintingHelper.PrintMainMenu();

				int.TryParse(Console.ReadLine(), out menuChoice);

				switch (menuChoice)
				{
					case 0:
						// exit program
						break;
					case 1:
						ShapesInterfaceInteraction shapesInterfaceInteraction = new ShapesInterfaceInteraction();
						shapesInterfaceInteraction.DisplayInterfaceMenu();
						break;

					case 2:
						PrintingHelper.PrintCartman();
						DisplayMainMenu();
						break;

					case 3:
						PrintingHelper.PrintZelda();
						DisplayMainMenu();
						break;

					case 4:
						PrintingHelper.PrintGregCongrats();
						DisplayMainMenu();
						break;

					case 5:
						DisplayMainMenu();
						break;

					case 6:
						DisplayMainMenu();
						break;

					default:
						Console.WriteLine("Oops, that is not a valid entry. Please try again.");
						DisplayMainMenu();
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

		#endregion private methods

	}
}
