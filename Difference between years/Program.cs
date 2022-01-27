using System;

namespace Difference_between_years
{
    class Program
    {
        //7kyp
        //Write a function that receives two strings as parameter.
        //This strings are in the following format of date: YYYY/MM/DD.
        //Your job is: Take the years and calculate the difference between them.
        public static int HowManyYears(string date1, string date2)
        {
            string[] firstArray = date1.Split('/');
            string[] secondArray = date2.Split('/');

            int first = Convert.ToInt32(firstArray[0]);
            int second = Convert.ToInt32(secondArray[0]);

            int result;

            if (first > second)
                result = first - second;
            else
                result = second - first;

            return result;
        }
        static void Main(string[] args)
        {
            string date1 = "1997/11/18";
            string date2 = "2022/07/30";

            Console.WriteLine("Difference between years : " + HowManyYears(date1, date2));
        }
    }
}
