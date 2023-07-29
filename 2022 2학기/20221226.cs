using System;
using System.Collections;
using System.Collections.Generic;

namespace _20221226
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Action + Ramda
            /*Action act1 = () => Console.WriteLine("Action()");
            act1();


            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine(result);

            Action<double, double> act3 = (x, y) => Console.WriteLine(x/y);*/
            #endregion

            #region Predicate + Ramda
            /*Predicate<int> isOdd =
                (x) =>
                {
                    return x % 2 == 0;
                };

            Console.WriteLine(isOdd(4));

            Predicate<string> isLowerCase =
                (x) =>
                {
                    return x.Equals(x.ToLower());
                };

            Console.WriteLine(Console.ReadLine());*/
            #endregion

            #region Predicate + List
            /*List<string> myList = new List<string> { "cat", "tiger", "elephant", };

            bool exist = myList.Exists(s => s.Contains("z"));
            Console.WriteLine("이름에 z를 포함하는 동물이 있는지 " + exist);

            string name = myList.Find(s => s.Length == 3);
            Console.WriteLine("이름이 3글자인 동물 이름 " + name);

            List<string> Longname = myList.FindAll(s => s.Length > 5);
            Console.WriteLine("6글자 이상인 동물 이름");
            foreach (var item in Longname)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();*/
            #endregion
        }
    }
}
