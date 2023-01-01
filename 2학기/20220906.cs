using System;
using System.Collections.Generic;

namespace _20220906
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            dynamic[] source = { 1, 9, 3, 10, 5 };
            dynamic[] target = { 5, 10, 3, 9, 1 };

            dynamic[] help = { };
            int i = 0;

            Rary(source, target);

            foreach (dynamic item in target)
            {
                source[i] = item;
                Console.WriteLine(item);
                i++;
            }
        }

        static dynamic Rary(dynamic[] Source, dynamic[] Target)
        {
            int j = 1;
            for (int i = 0; i < Source.Length; i++)
            {
                Target[Source.Length - j] = Source[i];
                j++;
            }
            return Target;
        }*/

        /*static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();

            for (int j = 0; j < 5; j++)
            {
                intList.Add(j);
                stringList.Add("alla" + j);
            }

            intList.Remove(3);
            stringList.Remove("alla3");
            intList.RemoveAt(2);
            stringList.RemoveAt(2);
        }*/

        /*static void Main(string[] args)
        {
            Queue<float> myQueue = new Queue<float>();
            myQueue.Enqueue(a);

            for(int i= 0; i < 5; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }*/

        /*static void Main(string[] args)
        {
            Stack<int> a = new Stack<int>();
            Stack<string> b = new Stack<string>();

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int j = random.Next(0, 9);
                a.Push(j);
            }
            for (int i = 0; i < 3; i++)
            {
                a.Pop();
            }
            Console.WriteLine(a);

            string[] q = { "apple", "banana", "C" };
            for (int i = 0; i < 3; i++)
            {
                b.Push(q[i]);
            }
            for (int i = 0; i < b.Count; i++)
            {
                b.Pop();
            }
            Console.WriteLine(b);
        }*/
    }
}
