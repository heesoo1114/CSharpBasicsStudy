using System;

namespace _20221220
{
    internal class Program
    {
        delegate int Area(int a, int b);
        delegate void Line();
        delegate double CalcMethod(double a, double b);

        delegate string Concatenate(string[] aray);

        delegate bool IsTeenAger(Student student);
        delegate bool IsAdult(Student student);

        

        static void Main(string[] args)
        {
            #region 1 main
            /*Area square = (x, y) => x * y;
            Console.WriteLine(square(5, 5));

            Line line = () => Console.WriteLine();
            line();

            CalcMethod add = delegate (double a, double b) { return a + b; };*/
            #endregion

            #region 2 main
            /*Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                    {
                        result += s;
                    }
                    return result; 
                };
                
            string[] arr = { "안녕", "잘가", "싫어" };
            Console.WriteLine(concat(arr));*/
            #endregion

            #region 3 main

            IsTeenAger isTeen = (student) => student.Age > 12 && student.Age < 20;

            Student S1 = new Student();
            S1.Name = "윤희수";
            S1.Age = 17;
            if (isTeen(S1))
                Console.WriteLine(S1.Name + "은 청소년입니다.");
            else
                Console.WriteLine(S1.Name + "은 청소년이 아닙니다.");

            IsAdult isAdult = (student) =>
            {
                if (student.Age >= 20)
                    return true;
                return false;
            };

            Student S2 = new Student();
            S2.Name = "경동엽";
            S2.Age = 16;
            if (isAdult(S2))
                Console.WriteLine(S2.Name + "은 성인입니다.");
            else
                Console.WriteLine(S2.Name + "은 성인이 아닙니다.");

            #endregion

            #region 4 main
            int[] arrr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Func<int, bool> o = (int i) =>
            {
                return i % 2 != 0;
            };
            int n = Count(arrr, o);
            Console.WriteLine($"짝수 갯수 : {n}개");
            Func<int, bool> f = (int i) =>
            {
                return i % 2 == 0;
            };
            n = Count(arrr, f);
            Console.WriteLine($"홀수 갯수 : {n}개");
            #endregion
        }

        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static int Count(int[] ints, Func<int, bool> func)
        {
            int cnt = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (func(i))
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
