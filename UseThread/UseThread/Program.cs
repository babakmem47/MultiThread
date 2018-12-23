using System;
using System.Threading;

namespace UseThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(Print1);
            t.Start();
            for (var i = 1; i < 1000; i++)
                Console.Write(0);
            Console.ReadLine();
        }

        static void Print1()
        {
            for (var i = 1; i < 1000; i++)
                Console.Write(1);
        }
    }
}
