using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X7
	{
		// LISTING 2-7 Using named and optional arguments
		public MainListing2X7()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X7");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			C.MyMethod(1, thirdArgument: true);

			Console.ReadLine();
		}
	}
}
