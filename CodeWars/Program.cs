using System;
using System.Linq;

namespace CodeWors
{
    class Program
    {

       //7 kyu
       // Given a string of words, return the length of the shortest word
        public static int FindShort (string s)
        {
            string[] w = s.Split(' ');

            int numbers = w.Length;

            int[] myArray;

            myArray = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                myArray[i] = w[i].Length;
            }

            int min = myArray[0];
            
            for (int i = 0; i < numbers; i++)
            {
                if (min > myArray[i])
                    min = myArray[i];
            }

            return min;

        }
        static void Main(string[] args)
        {
            string test = "dfsdf oc kjhj lkjoj lj lijk";

            Console.WriteLine("The shortest word includes {0} chars", FindShort(test));

        }
    }
}
