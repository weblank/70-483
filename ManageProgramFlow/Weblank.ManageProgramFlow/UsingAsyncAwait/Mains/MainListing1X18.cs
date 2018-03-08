using System;
using UsingAsyncAwait.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAsyncAwait.Mains
{
    public class MainListing1X18
    {
        public MainListing1X18()
        {
            var result = new DownloadClass().DownloadContent().Result;
            Console.WriteLine(result);
        }
    }
}
