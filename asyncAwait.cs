using System;
using System.Threading;
using System.Threading.Tasks;

namespace learning
{
    class asyncAwait
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Exercise();
            Console.ReadLine();
        }
        public static async void Exercise()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartWarmup();
            await task1;
            var task2 = running1();
            var task3 = running2();

            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");
            Console.WriteLine("Thankyou");
        }
        public static async Task StartWarmup()
        {
            await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Warmup Completed");
                });
        }
        public static async Task running1()
        {
            await Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Completed 1 km running");
                });
        }
        public static async Task running2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Completed 2 km running");
            });
        }
    }
}
