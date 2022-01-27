using System;
using System.Linq;

namespace Square_Every_Digit
{
    class Program
    {
        // 7kyp
        //In this kata, you are asked to square every digit of a number and concatenate them.
        //Note: The function accepts an integer and returns an integer.

        public static int SquareDigits(int n)
        {
            int[] Array = n.ToString().ToCharArray().Select(b => b - '0').ToArray();
            int pow = 0;
            string result = "";

            for (int i = 0; i < Array.Length; i++)
            {
                pow = Convert.ToInt32(Math.Pow(Array[i], 2));
                result += pow.ToString();
            }

            int myResult = Convert.ToInt32(result);
            return myResult;
        }
        static void Main(string[] args)
        {   
            int check = 4578;
            Console.WriteLine(SquareDigits(check));
        }
    }
}
