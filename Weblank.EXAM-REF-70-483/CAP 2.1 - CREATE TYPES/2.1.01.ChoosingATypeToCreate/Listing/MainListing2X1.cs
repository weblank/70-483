using ChoosingATypeToCreate.Enumerators;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X1
	{
		// LISTING 2-1 Using the FlagAttribute for an enum
		public MainListing2X1()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X1");
			Console.WriteLine("----------------------------------------------------------------");

			Days readingDays = Days.Monday | Days.Saturday;

			Console.WriteLine(readingDays);

			Console.ReadLine();
		}
	}
}
