using ChoosingATypeToCreate.Structs;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X02
	{
		// LISTING 2-02 Creating a custom struct
		public MainListing2X02()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X02");
			Console.WriteLine("----------------------------------------------------------------");

			Point P = new Point(21, 32);

			Console.WriteLine("Point.x: " + P.x);
			Console.WriteLine("Point.y: " + P.y);

			Console.ReadLine();
		}
	}
}
