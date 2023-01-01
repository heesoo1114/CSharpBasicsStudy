using System;

namespace _20221108
{
    internal class Program
    {
        delegate bool MemberTest(int a);

        static int Count(int[] arr, MemberTest memberTest)
        {
            int cnt = 0;
            /*for (int i = 0; i < arr.Length; i++)
            {
                if (memberTest(arr[i]))
                {
                    cnt++;
                }
            }*/

            foreach (int item in arr)
            {
                if (memberTest(item))
                {
                    cnt++;
                }
            }

            return cnt;
        }

        static void Main(string[] args)
        {
            #region 1번 문제
            /*int[] arr = { 1, 2, 3 };

            MemberTest Even = delegate (int a)
            {
                return a % 2 == 0; 
            };

            MemberTest Odd = delegate (int a)
            {
                return !(a % 2 == 0);
            };

            int even = Count(arr, Even);
            Console.WriteLine($"짝수의 개수 : {even}");
            
            int odd = Count(arr, Odd);
            Console.WriteLine($"홀수의 개수 : {odd}");*/
            #endregion

            #region 2번 문제
            /*MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 0; i < 31; i++)
            {
                notifier.DoSomething(i);
            }*/
            #endregion
        }

        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        delegate void EventHandler(string message);

        class MyNotifier
        {
            public event EventHandler SomethingHappened;
            public void DoSomething(int number)
            {
                if (number != 0 && number % 3 == 0)
                {
                    SomethingHappened($"{number} : 3의 배수");
                }
            }
        }
    }
}
