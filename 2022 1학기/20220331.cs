using System;

namespace _2200331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   <윤년>
            int year = int.Parse(Console.ReadLine());
            
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("윤년");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("윤년");
            }
            else
            {
                Console.WriteLine("윤년이아니다");
            } 
        } */

            /*  <주사위>
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            if (a == b && b == c)
            {
                Console.WriteLine(10000 + (a * 1000));
            }
            else if (a == b)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (a == c)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (c == b)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else
            {
                if (a > b && a > c)
                {
                    Console.WriteLine(a * 100);
                }
                else if (b > c)
                {
                    Console.WriteLine(b * 100);
                }
                else
                {
                    Console.WriteLine(c * 100);
                }
            }
        }
        */

            /*    <알람>
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (h == 0)
            { 
                
                if (m >= 45)
                {
                    Console.WriteLine(h);
                    Console.WriteLine(m - 45);
                }
                else if (m < 45)
                {
                    Console.WriteLine(23);
                    Console.WriteLine(60 + (m - 45));
                }
            }
            else
            {
                if (m >= 45)
                {
                    Console.WriteLine(h);
                    Console.WriteLine(m - 45);
                }
                else if (m < 45)
                {
                    Console.WriteLine(h -= 1);
                    Console.WriteLine(60 + (m - 45));
                }
            } */


          



        }
    }
}
