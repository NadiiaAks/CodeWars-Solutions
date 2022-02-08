using System;

namespace zz
{
    class Program
    {
        


        static void Main(string[] args)
        {
            int x = 10;

            switch (x)
            {
                case 10: { goto case 12; Console.WriteLine(++x); break; }
                case 11: { Console.WriteLine( 11); break; }
                case 12: { Console.WriteLine(x--); break; }
            }



        }
    }
}
