using System;

namespace WorkingWithBooleanExpressions.Listing
{
    public class MainListing1X50
    {
        public void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));

            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
