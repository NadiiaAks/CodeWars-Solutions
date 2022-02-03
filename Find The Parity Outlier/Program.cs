using System;

namespace Find_The_Parity_Outlier
{
    class Program
    {

        // 6 kpu
        // You are given an array. The array is either entirely comprised of odd integers or entirely comprised of even integers except
        // for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.
        public static int Find(int[] integers)
        {
            int check = 0;

            for (int i = 0; i < 3; i++)
            {
                if (integers[i] % 2 == 0)
                    check = check + 1;
            }

            int result = 0;

            if (check >= 2)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 != 0)
                        result = integers[i];
                }
            }
            else
            for (int j = 0; j < integers.Length; j++)
            {
                    if (integers[j] % 2 == 0)
                        result = integers[j];
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            int[] exemple = { 22, 2, 4, 7, 8, 12 };
            int result = Find(exemple);
            
            Console.WriteLine(result);
        }
    }
}
