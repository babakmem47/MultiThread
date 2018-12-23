using System;
using System.Threading;

namespace PassParametizedFuncToThread
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////// passing data class: Number ///////////////////////////////////////////////

            Console.WriteLine("Please enter a number: ");
            object target = Console.ReadLine();

            //static call:
            //            var parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumber);

            //non static call:
            var number = new Number();
            var parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);

            var t = new Thread(parameterizedThreadStart);
            t.Start(target);
            /////////////////////////////////////////////////////////////////////////////////////////


            /////////////// passing data in a type safe manner  class: Number2 //////////////////////

            Console.WriteLine("Enter number:");
            var target2 = Convert.ToInt32(Console.ReadLine());

            var number2 = new Number2(target2);
            var t2 = new Thread(new ThreadStart(number2.PrintNumber));
            t2.Start();
            /////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
