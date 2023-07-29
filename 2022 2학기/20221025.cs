using System;

namespace _20221025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1번 문제
            /*int[] arr = new int[3];

            try
            {
                Console.WriteLine(arr[100]);
            }
            catch
            {
                Console.WriteLine("에러가 발생했습니다");
            }*/
            #endregion

            #region 2번 문제
            /*try
            {
                int x, y;

                Console.WriteLine("x의 값을 입력하시오");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("y의 값을 입력하시오");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"예외가 발생했습니다 : {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
            }*/
            #endregion

            #region 3번 문제
            /*try
            {
                int x;
                DoSomething(x = int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            #endregion

            #region 4번 문제
            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int dividend = int.Parse(Console.ReadLine());

                Divide(divisor, dividend);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");
            }
            #endregion
        }

        // 3번 문제 DoSomething 메소드
        static void DoSomething(int num)
        {
            if (num < 10)
            {
                Console.WriteLine("num : {0}", num);
            }
            else if (num == 10)
            {
                throw new Exception("num이 10과 동일합니다");
            }
            else
            {
                throw new Exception("num이 10보다 큽니다.");
            }
        }

        // 4번 문제 Divide 메소드
        static int Divide(int divisor, int dividend)
        {
            try
            {
                return divisor / dividend;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("예외가 발생함");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide 끝");
            }
        }
    }
}
