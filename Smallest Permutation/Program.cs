using System;
using System.Collections.Generic;
using System.Linq;

namespace Smallest_Permutation
{
    class Program
    {
        //Sort the number, from smallest elements to largest
        static public int MinPermutation(int n)
        {
           
            string str = n.ToString();
            int[] myArray = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
               myArray[i] = int.Parse(str[i].ToString());
            }

            Array.Sort(myArray);

            int value = 0;
            for (int i = 0; i < myArray.Length; i++)
{
                value *= 10;
                value += myArray[i];
            }

            return value;
        }

        static void Main(string[] args)
        {
            int my = 29831;

            int check = MinPermutation(my);

            Console.WriteLine(check);
            
        }
    }
}
