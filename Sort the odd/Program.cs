using System;
using System.Linq;

namespace Sort_the_odd
{
    class Program
    {

        //6 kpu
        //You will be given an array of numbers.
        //You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
        public static int[] SortArray (int[] array)
        {
            int[] odd = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();

            for (int i = 0, j =0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 )
                {
                    array[i] = odd[j];
                    j++;
                }
            }

            return array;
        }
        
        static void Main(string[] args)
        {
            int[] myArray = { 5, 8, 6, 3, 4 };

            int[] check = SortArray(myArray);
        }
    }
}
