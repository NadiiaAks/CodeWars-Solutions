using System;

namespace Phone_Number
{

    //6 kpu
    //Write a function that accepts an array of 10 integers (between 0 and 9),
    //that returns a string of those numbers in the form of a phone number.
    class Program
    {
        static void Main(string[] args)
        {
            int[] checkArray = new int[] { 0, 8, 8, 6, 5, 0, 9, 8, 7, 3 };

            string result = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", checkArray[0], checkArray[1], checkArray[2], checkArray[3], checkArray[4], checkArray[5], checkArray[6], checkArray[7], checkArray[8], checkArray[9]);

            Console.WriteLine(result);


        }
    }
}
