using System;
using System.Threading;

namespace Sleep
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
