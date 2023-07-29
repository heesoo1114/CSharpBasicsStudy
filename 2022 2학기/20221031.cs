using System;

namespace _20221031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1번 문제
            /*SayDelegate say = Hi;
            say();
            say?.Invoke();

            SayDelegate hi = new SayDelegate(Hi);
            hi();*/
            #endregion

            #region 2번 문제
            Calculator Calc = new Calculator();

            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
            #endregion
        }

        delegate void SayDelegate();

        delegate int MyDelegate(int a, int b);

        class Calculator
        {
            public int Plus(int a, int b)
            {
                return a + b; 
            }

            public static int Minus(int a, int b)
            {
                return a - b;
            }
        }

        public static void Hi()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}
