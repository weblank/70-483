using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X05
	{
		// LISTING 2-05 Passing a complete customer to a method
		public MainListing2X05()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X05");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			Distance D = C.CalculateDistanceTo(new Customer());

			Console.ReadLine();
		}
	}
}
