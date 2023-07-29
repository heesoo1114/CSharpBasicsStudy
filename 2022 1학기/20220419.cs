using System;
using System.Threading;

namespace _20220419
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int x = 1;
            int y = 1;

            while (x < 50 )
            {

                Console.Clear();
                Console.SetCursorPosition(x, y);


                if (x % 3 == 0 || y % 3 == 0)
                {
                    Console.WriteLine(" __0");
                }
                else if (x % 3 == 1 || y % 3 == 1)
                {
                    Console.WriteLine("_^0");
                }
                else
                {
                    Console.WriteLine("^_0");
                }

                Thread.Sleep(100);
                x++;
                y++;
                */

              int x = 1;
              
              
            while(x < 50)
            {

                Console.Clear();
                Console.SetCursorPosition(x, 0);

                if (x % 3 == 0)
                {
                    Console.WriteLine(" __0");
                }
                else if (x % 3 == 1)
                {
                    Console.WriteLine("_^0");
                }
                else
                {
                    Console.WriteLine("^_0");
                }

                Thread.Sleep(100);
                x++;

            }

           



        }

        }
    }

