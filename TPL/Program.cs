using System;
using System.Threading;

namespace TPL
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");


            AsyncAwait aa = new AsyncAwait();
            //Console.WriteLine("Button clicked");
            //await aa.ShowThreadAsync();
            //Console.WriteLine("About to show dialog");
            //Console.WriteLine("Success...!!!");
            //Console.WriteLine("==========================");

            //await aa.OnButtonClick();

            await aa.TaskRun();
            Console.WriteLine("Success...!!!");
            Console.ReadLine();
        }
    }
}
