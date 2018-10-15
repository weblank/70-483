using ChoosingATypeToCreate.Enumerators;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X01
	{
		// LISTING 2-01 Using the FlagAttribute for an enum
		public MainListing2X01()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X01");
			Console.WriteLine("----------------------------------------------------------------");

			Days readingDays = Days.Monday | Days.Saturday;

			Console.WriteLine(readingDays);

			Console.ReadLine();
		}
	}
}
