using System;

namespace Digitize
{
    class Program
    {
        // 7 kpu
        //Given a non-negative integer, return an array / a list of the individual digits in order
        public static int[] digitize(int n)
        {

            char[] num = n.ToString().ToCharArray();
            int[] result = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                result[i] = int.Parse(Convert.ToString(num[i]));
            }

            return result;
        }

        static void Main(string[] args)
        {
            int check = 12345;

            int[] myArray = digitize(check);
        
        }
    }
}
