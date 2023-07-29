using System;
using System.Threading;

namespace _20220913
{
    internal class Program
    {
        // 1번 문제
        /*class car
        {
            int id;
            string name;

            public car(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            ~car()
            {
                Console.WriteLine(DateTime.Now + "시점에 소멸자 호출됨");
            }
        }

        void test()
        {
            car car = new car(32, "ddd");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.test();

            Console.WriteLine(DateTime.Now);

            GC.Collect(); // 소멸자 호출되도록 함

            Thread.Sleep(1000); // 스레드가 1초간 정지하도록
        }*/


        // 2번 문제
        /*class Abc
        {
            private int[] array;
            
            public int this[int index]
            {
                get
                {
                    return array[index];  
                }

                set
                {
                    if(index >= array.Length)
                    {
                        Console.WriteLine("접근할 수 없는 인덱스 입니다");
                    }

                    array[index] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Abc abc = new Abc();
            for(int i = 0; i < 5; i++)
            {
                abc[i] = i;
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(abc[i]);
            }
        }*/

        // 3번째 문제
        /*class Week
        {
            private string[] weeks;

            public Week()
            {
                weeks = new string[7];
            }

            public string this[int i]
            {
                get
                {
                    return weeks[i];
                }
                set
                {
                    if (i >= weeks.Length)
                    {
                        Console.WriteLine("");
                    }
                    weeks[i] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Week w = new Week();

            string[] a = { "월", "화", "수", "목", "금", "토", "일" };
            for (int i = 0; i < 7; i++)
            {
                w[i] = a[i];
            }

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(w[i]);
            }
        }*/
    }
}
