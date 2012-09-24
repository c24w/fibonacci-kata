namespace Fibonacci
{
    class FibonacciGenerator
    {

        public int GetFibonacci(int sequenceNumber)
        {
            if (sequenceNumber <= 2) return 1;
            return GetFibonacci(sequenceNumber - 1) + GetFibonacci(sequenceNumber - 2);
        }

    }   
}
   