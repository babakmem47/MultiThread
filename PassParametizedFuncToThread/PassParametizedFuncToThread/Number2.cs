using System;

namespace PassParametizedFuncToThread
{
    class Number2
    {
        private readonly int _target;

        public Number2(int target)    // constructor for initialize _target
        {
            this._target = target;
        }

        public void PrintNumber()
        {
            for (int i = 0; i < _target; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}