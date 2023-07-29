using System;

namespace _20220414
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("두 수를 입력해주세요");

            int N = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());

            
            int[] array = new int[N];
            

            for (int i = 0; i < N; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < N; i++)
            {

                if ( array[i] < X)
                {
                    Console.WriteLine(array[i]);
                }

            }


        }
    }
}
