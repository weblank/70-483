using System;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X62
    {
        // A complex if statement
        public void Check(Char input)
        {

            switch(input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Input is a vowel");
                        Console.ReadLine();
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("Input is sometimes a vowel");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input is a consonant");
                        Console.ReadLine();
                        break;
                    }

            }

        }
    }
}
