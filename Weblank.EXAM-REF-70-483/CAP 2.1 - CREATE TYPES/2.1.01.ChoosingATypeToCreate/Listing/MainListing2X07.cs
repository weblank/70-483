using ChoosingATypeToCreate.Classes;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X07
	{
		// LISTING 2-07 Using named and optional arguments
		public MainListing2X07()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X07");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			C.MyMethod(1, thirdArgument: true);

			Console.ReadLine();
		}
	}
}
