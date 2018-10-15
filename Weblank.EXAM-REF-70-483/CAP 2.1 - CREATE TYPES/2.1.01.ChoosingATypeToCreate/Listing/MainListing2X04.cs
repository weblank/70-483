using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X04
	{
		// LISTING 2-04 Creating a method
		public MainListing2X04()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X04");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			int sum = C.Add(21, 43);

			Console.WriteLine("sum: " + sum);

			Console.ReadLine();
		}
	}
}
