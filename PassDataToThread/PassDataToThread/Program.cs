using System;
using System.Threading;

namespace PassDataToThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(() => CountTo(100));
            t.Start();

            new Thread(() =>
            {
                CountTo(25);
                CountTo(20);
            }).Start();

            Console.ReadLine();
        }

        static void CountTo(int maxNumber)
        {
            for (int i = 0; i < maxNumber; i++)
            {
                Console.Write(i + " ");
            }
        }

    }
}
