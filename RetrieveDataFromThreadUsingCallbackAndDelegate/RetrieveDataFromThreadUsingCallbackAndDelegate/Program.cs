

using System;
using System.Threading;

namespace RetrieveDataFromThreadUsingCallbackAndDelegate
{
    public delegate void SumOfNumbersCallBack(int sumOfNumbers);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            var target = Convert.ToInt32(Console.ReadLine());

            var callback = new SumOfNumbersCallBack(PrintSum);

            var number = new Number(target, callback);
            var t = new Thread(number.PrintSumOfNumbers);
            t.Start();  
        }

        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of Numbers is: {0}", sum);
        }
    }
}
