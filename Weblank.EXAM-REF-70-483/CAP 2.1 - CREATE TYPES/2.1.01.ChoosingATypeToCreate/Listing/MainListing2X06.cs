using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X06
	{
		// LISTING 2-06 Passing only an address to a method
		public MainListing2X06()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X06");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			Distance D = C.CalculateDistanceTo(new Address());

			Console.ReadLine();
		}
	}
}
