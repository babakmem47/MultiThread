namespace RetrieveDataFromThreadUsingCallbackAndDelegate
{
    class Number
    {
        private readonly int _target;
        private readonly SumOfNumbersCallBack _callBackMethod;
        public Number(int target, SumOfNumbersCallBack callBackMethod)
        {
            _target = target;
            _callBackMethod = callBackMethod;
        }

        public void PrintSumOfNumbers()
        {
            var sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum += i;
            }

            if (_callBackMethod != null)
            {
                _callBackMethod(sum);
            }
            
        }

    }
}