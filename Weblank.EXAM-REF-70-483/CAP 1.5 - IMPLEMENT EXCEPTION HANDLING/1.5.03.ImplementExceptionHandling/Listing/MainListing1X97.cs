using System;
using System.Runtime.ExceptionServices;

namespace _1._5._03.ImplementExceptionHandling
{
    //   Using ExceptionDispatchInfo.Throw
    public class MainListing1X97
    {
        public MainListing1X97()
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }
            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
        
    }
}


