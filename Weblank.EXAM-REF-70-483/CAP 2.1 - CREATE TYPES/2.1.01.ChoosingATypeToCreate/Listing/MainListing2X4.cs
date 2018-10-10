using ChoosingATypeToCreate.Entities;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X4
	{
		// LISTING 2-4 Creating a method
		public MainListing2X4()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X4");
			Console.WriteLine("----------------------------------------------------------------");

			Calculator C = new Calculator();
			int sum = C.Add(21, 43);

			Console.WriteLine("sum: " + sum);

			Console.ReadLine();
		}
	}
}
