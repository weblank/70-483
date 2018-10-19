using ChoosingATypeToCreate.Classes;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X17
	{
		// LISTING 2-17 Overriding a virtual method
		public MainListing2X17()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X17");
			Console.WriteLine("----------------------------------------------------------------");

			Derived derived = new Derived();
			derived.MyMethod().ToString();

			Console.WriteLine("Derived.MyMethod: " + derived.MyMethod().ToString());

			Console.ReadLine();
		}
	}
}
