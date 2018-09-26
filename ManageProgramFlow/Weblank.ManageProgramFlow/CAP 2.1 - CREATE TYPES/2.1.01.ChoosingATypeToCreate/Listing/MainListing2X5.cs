using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X5
	{
		// LISTING 2-5 Passing a complete customer to a method
		public MainListing2X5()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X5");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			Distance D = C.CalculateDistanceTo(new Customer());

			Console.ReadLine();
		}
	}
}
