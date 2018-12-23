using System;

namespace PassParametizedFuncToThread
{
    class Number
    {
        public static void PrintNumber(object target)    // static
        {
            var number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (var i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintNumbers(object target)         // non static
        {
            var number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (var i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }


    }
}