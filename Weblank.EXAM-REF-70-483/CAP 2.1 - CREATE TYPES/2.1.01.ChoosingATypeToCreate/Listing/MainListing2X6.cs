using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X6
	{
		// LISTING 2-6 Passing only an address to a method
		public MainListing2X6()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X6");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			Distance D = C.CalculateDistanceTo(new Address());

			Console.ReadLine();
		}
	}
}
