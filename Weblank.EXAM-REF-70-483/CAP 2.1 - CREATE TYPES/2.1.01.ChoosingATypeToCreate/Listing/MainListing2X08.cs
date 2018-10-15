using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X08
	{
		// LISTING 2-08 Returning data from a method
		public MainListing2X08()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X08");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			C.MyMethod(1, thirdArgument: true);

			Console.ReadLine();
		}
	}
}
