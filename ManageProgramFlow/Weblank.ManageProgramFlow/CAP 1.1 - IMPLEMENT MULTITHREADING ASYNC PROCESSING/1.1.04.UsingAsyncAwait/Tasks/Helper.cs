using System.Net.Http;
using System.Threading.Tasks;

namespace UsingAsyncAwait.Tasks
{
    public class DownloadClass
    {
        public async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result; 
            }
        }
    }
}
