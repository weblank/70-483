using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UsingAsyncAwait.Mains;

namespace UsingAsyncAwait
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.1: IMPLEMENT MULTITHREADING AND ASYNCHRONOUS PROCESSING CHAPTER 1

    public class Program
    {
        static void Main(string[] args)
        {
            //Listing 1.18 - Async and Await
            #region Listing 1.18
            //var main = new MainListing1X18();            
            #endregion

            //Listing 1.19 - Scability versus Responsiveness
            #region Listing 1.19
            //var main = new MainListing1X19();
            //main.SleepAsyncA(1000);
            //main.SleepAsyncB(1000);
            #endregion


            #region Exemplos de ConfigureAwait == false
            //Listing 1.20 - Using ConfigureAwait
            #region Listing 1.20
            //Apenas um exemplo de código em um cenário de WPF

            //private async void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    HttpClient httpClient = new HttpClient();
            //    string content = await httpClient
            //                                .GetStringAsync("http://www.microsoft.com")
            //                                .ConfigureAwait(false);

            //    //Teremos uma exception neste trecho considerando que o configureAwait == false;
            //    Output.Content = content;
            //}
            #endregion

            //Listing 1.21 - Continuing on a Thread pool instead of the UI thread
            #region Listing 1.21
            //Apenas um exemplo de código em um cenário de WPF

            //private async void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    HttpClient httpClient = new HttpClient();
            //    string content = await httpClient
            //    .GetStringAsync("http://www.microsoft.com")

            //    .ConfigureAwait(false);

            //    using (FileStream sourceStream = new FileStream("temp.html",FileMode.Create, FileAccess.Write, FileShare.None,4096, useAsync: true))
            //    {
            //        byte[] encodedText = Encoding.Unicode.GetBytes(content);
            //        await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
            //        .ConfigureAwait(false);
            //    };
            //}
            #endregion 
            #endregion
        }


    }

}
