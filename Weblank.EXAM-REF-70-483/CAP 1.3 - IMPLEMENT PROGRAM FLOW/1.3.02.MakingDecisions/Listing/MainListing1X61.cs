using System;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X61
    {
        // A complex if statement
        public void Check(Char input)
        {

            if(input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Input is a consonant");
                Console.ReadLine();

            }

        }
    }
}
