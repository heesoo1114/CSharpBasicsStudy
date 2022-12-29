using System;

namespace _20220329
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전");
            }
            if (DateTime.Now.Hour >= 12)
            {
                Console.WriteLine("오후");
            }


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (a > b)
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("==");
                }
            }
            else
            {
                Console.WriteLine("<");
            }




            int T = int.Parse(Console.ReadLine());

            if (T > 89 && T <= 100)
            {
                Console.WriteLine("A");
            }
            else if (T > 79 && T < 90)
            {
                Console.WriteLine("B");
            }
            else if (T > 69 && T < 80)
            {
                Console.WriteLine("C");
            }
            else if (T > 59 && T < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }




            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("제 1사분면");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("제 2사분면");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("제 3사분면");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("제 4사분면");
            }
            else
            {
                Console.WriteLine("원점");
            }
        }
    }
}
