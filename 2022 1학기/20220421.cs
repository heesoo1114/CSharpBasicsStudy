using System;

namespace _20220421
{
    class MainApp
    {
        public static double Square(double a)
        {
            double result = a * a;
            return result;


        }


        static void Main(string[] args)
        {
            /*
            int x = 2 + 3;
            int y = 1 + 4;

            
            int box = calucalter.Plus(x, y);
            Console.WriteLine(box);
            */

            Console.WriteLine("수를 입력해주세요 : ");
            string input = Console.ReadLine();
            double arg = double.Parse(input);

            Console.WriteLine("결과 : " + Square(arg));



        }
    }
    }





