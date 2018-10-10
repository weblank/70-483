using ChoosingATypeToCreate.Structs;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X2
	{
		// LISTING 2-2 Creating a custom struct
		public MainListing2X2()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X2");
			Console.WriteLine("----------------------------------------------------------------");

			Point P = new Point(21, 32);

			Console.WriteLine("Point.x: " + P.x);
			Console.WriteLine("Point.y: " + P.y);

			Console.ReadLine();
		}
	}
}
