using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X8
	{
		// LISTING 2-8 Returning data from a method
		public MainListing2X8()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X8");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			C.MyMethod(1, thirdArgument: true);

			Console.ReadLine();
		}
	}
}
