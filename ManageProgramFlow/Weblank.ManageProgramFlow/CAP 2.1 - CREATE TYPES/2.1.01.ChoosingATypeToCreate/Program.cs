using System;
using ChoosingATypeToCreate.Enumerators;
using ChoosingATypeToCreate.Structs;
using ChoosingATypeToCreate.Entities;

namespace ChoosingATypeToCreate
{
	// CHAPTER 2 CREATE AND USE TYPES
	// OBJECTIVE 2.1: CREATE TYPES

	public class Program
	{
		static void Main(string[] args)
		{
			// LISTING 2-1 Using the FlagAttribute for an enum
			#region Listing 2.1

			// MainListing2X1();

			#endregion

			// LISTING 2-2 Creating a custom struct
			#region Listing 2.2

			// MainListing2X2();

			#endregion

			// LISTING 2-3 Calling a method
			#region Listing 2.3

			//MainListing2X3();

			#endregion

			// LISTING 2-4 Creating a method
			#region Listing 2.4

			// MainListing2X4();

			#endregion

			// LISTING 2-5 Passing a complete customer to a method
			#region Listing 2.5

			// MainListing2X5();

			#endregion

			// LISTING 2-6 Passing only an address to a method
			#region Listing 2.6

			// MainListing2X6();

			#endregion

			// LISTING 2-7 Using named and optional arguments
			#region Listing 2.7

			// MainListing2X7();

			#endregion

			// LISTING 2-8 Returning data from a method
			#region Listing 2.8

			MainListing2X8();

			#endregion
		}

		#region Main Listings

		// LISTING 2-1 Using the FlagAttribute for an enum
		static void MainListing2X1()
		{
			Days readingDays = Days.Monday | Days.Saturday;

			Console.WriteLine(readingDays);

			Console.ReadLine();
		}

		// LISTING 2-2 Creating a custom struct
		static void MainListing2X2()
		{
			Point P = new Point(21, 32);

			Console.WriteLine("Point.x: " + P.x);
			Console.WriteLine("Point.y: " + P.y);

			Console.ReadLine();
		}

		// LISTING 2-3 Calling a method
		static void MainListing2X3()
		{
			Console.WriteLine("I’m calling a method!");

			Console.ReadLine();
		}

		// LISTING 2-4 Creating a method
		static void MainListing2X4()
		{
			Calculator C = new Calculator();
			int sum = C.Add(21, 43);

			Console.WriteLine("sum: " + sum);

			Console.ReadLine();
		}

		// LISTING 2-5 Passing a complete customer to a method
		static void MainListing2X5()
		{
			Calculator C = new Calculator();
			Distance D = C.CalculateDistanceTo(new Customer());
			
			Console.ReadLine();
		}

		// LISTING 2-6 Passing only an address to a method
		static void MainListing2X6()
		{
			Calculator C = new Calculator();
			Distance D = C.CalculateDistanceTo(new Address());

			Console.ReadLine();
		}

		// LISTING 2-7 Using named and optional arguments
		static void MainListing2X7()
		{
			Calculator C = new Calculator();
			C.MyMethod(1, thirdArgument: true);

			Console.ReadLine();
		}

		// LISTING 2-8 Returning data from a method
		static void MainListing2X8()
		{
			Calculator C = new Calculator();
			C.MyMethod(1, thirdArgument: true);

			Console.ReadLine();
		}

		#endregion
	}
}
