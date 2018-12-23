using System;
using System.Threading;

namespace LockThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(10);
            var threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            for (var i = 0; i < 15; i++)  // create 15 threads, name them and put them in array
            {
                var t = new Thread(account.IssueWithdraw); ;
                t.Name = i.ToString();
                threads[i] = t;
            }

            for (int i = 0; i < 15; i++)     // execute threads and check status of them
            {
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

                threads[i].Start();

                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

            }

            Console.WriteLine("Current priority: {0}", Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} ending", Thread.CurrentThread.Name);

            Console.ReadLine();
        }
    }
}
