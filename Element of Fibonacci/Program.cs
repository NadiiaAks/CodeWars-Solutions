using System;

namespace Element_of_Fibonacci
{
    class Program
    {
        //7kpu
        //Create function fib that returns n'th element of Fibonacci sequence 
        public static int Fib(int n)
        {
            int[] fib = new int[n + 2];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            int result = fib[n];

            return result;
        }

        static void Main(string[] args)
        {
            int fib = Fib(7);
        }
    }
}
