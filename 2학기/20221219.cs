using System;

namespace _20221219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1번 Main
            /*MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += MyHandeler;

            for (int i = 1; i <= 30; i++)
            {
                notifier.DoSomething(i);
            }*/
            #endregion

            #region 2번 Main
            /*Button btn = new Button();
            btn.Click += Hi1;
            btn.Click += Hi2;

            btn.OnClick();*/
            #endregion
        }

        #region 1번
        /*class MyNotifier
        {
            internal delegate void EventHandler(string s);
            internal event EventHandler SomethingHappened;

            public void DoSomething(int num)
            {
                if (num % 3 == 0)
                {
                    SomethingHappened($"{num} : 3의 배수");
                }
            }
        }
        
        
        static public void MyHandeler(string message)
        {
            Console.WriteLine(message);
        }*/
        #endregion

        #region 2번
        /*class Button
        {
            internal delegate void EventHandler();
            internal event EventHandler Click;

            public void OnClick()
            {
                Click?.Invoke();
            }
        }

        static public void Hi1()
        {
            Console.WriteLine("C#");
        }

        static public void Hi2()
        {
            Console.WriteLine(".NET");
        }*/
        #endregion
    }
}
