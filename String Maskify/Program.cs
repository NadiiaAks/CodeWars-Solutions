using System;

namespace String_Maskify
{
    class Program
    {
        // 7kyp
        // Usually when you buy something, you're asked whether your credit card number,
        // phone number or answer to your most secret question is still correct.
        // However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.
        // Your task is to write a function maskify, which changes all but the last four characters into '#'.
        public static string Maskify(string cc)
        {
            char[] MyArray = cc.ToCharArray();

            for (int i = 0; i <= MyArray.Length - 5; i++)
            {
                MyArray[i] = '#';
            }
            string NewString = new string(MyArray);

            return NewString;

        }
        static void Main(string[] args)
        {
            string card = "1234 3212 3111 9099";
            Console.WriteLine("String {0}, new string {1}", card, Maskify(card));
        }
    }
}
