using System;

namespace _20221107
{
    internal class Program
    {
        delegate void SendString(string str);

        void Hello(string str)
        {
            Console.WriteLine($"안녕하세요 {str}씨");
        }

        void GoodBye(string str)
        {
            Console.WriteLine($"안녕히가세요 {str}씨");
        }

        static void Main(string[] args)
        {
            #region 1번 문제
            Program program = new Program();
            
            SendString SayHello = new SendString(program.Hello);
            SendString SayGoodBye = new SendString(program.GoodBye);
           
            SendString MultiDelegate = new SendString(SayHello);
            MultiDelegate += new SendString(SayGoodBye);

            MultiDelegate("윤희수");
            MultiDelegate -= new SendString(SayGoodBye);
            MultiDelegate("윤희수");
            #endregion
        }

        /*static void BubbleSort<T>(T[] array, Compare<T> comparer)
        {
            int i = 0;
            int j = 0;
            T temp;
            for (i = 0; i < array.Length - 1; i++)
            {
                for (j = 0; j < array.Length - (i + 1); j++)
                {
                    if (comparer(array[j], array[j + 1]) > 0)
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Compare<int> ascend = delegate (int a, int b)
            {
                if (a > b) return 1;
                else if (a < b) return -1;
                return 0;
            };

            Compare<int> descend = delegate (int a, int b)
            {
                if (a > b) return -1;
                else if (a < b) return 1;
                return 0;
            };

            int[] arr = new int[] { 0, 6, 8, 1, 7 };
            BubbleSort(arr, ascend);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            BubbleSort(arr, descend);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }*/
    }
}
}
