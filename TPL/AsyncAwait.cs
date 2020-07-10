using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    public class AsyncAwait
    {
        public async Task ShowThreadAsync()
        {
            Console.WriteLine(new System.Diagnostics.StackTrace());
            Console.WriteLine("About to download");
            Console.WriteLine("I am here....");
            await WebCallAsync();
            Console.WriteLine("Finished downloading...about to blue");
            await WebCallAsync();
            Console.WriteLine("Finished blurring...about to save");
            await WebCallAsync();
            Console.WriteLine("Done saving");
        }

        public async Task WebCallAsync()
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("https://news.google.com/topstories?hl=en-IN&tab=rn&gl=IN&ceid=IN:en");
            Console.WriteLine($"{responseMessage.StatusCode}");
        }

        public async Task OnButtonClick()
        {
            string imageUrl = null;
            try
            {
                await DownloadAndBlur(imageUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
            Console.WriteLine("Done!");
        }

        async Task DownloadAndBlur(string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            
}

        public async Task TaskRun()
        {
            Task.Run(() =>
            {
                for(int i =0;i < int.MaxValue;i++)
                {
                    Console.Write(i);
                }
            });

            Console.WriteLine("I am here");
        }
    }
}
