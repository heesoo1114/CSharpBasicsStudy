using System;

namespace _20221101
{
    internal class Program
    {
        delegate int Campare<T>(T a, T b);

        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return b.CompareTo(a);
        }

        static void Main(string[] args)
        {
            #region 1번 문제
            /*int[] array = { 5, 3, 7, 9, 1 };
            BubbleSort(array, AscendCompare);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            int[] array2 = { 6, 4, 8, 2, 10 };
            BubbleSort(array2, DescendCompare);

            for (int j = 0; j < array2.Length; j++)
            {
                Console.Write(array2[j]);
            }*/
            #endregion
        }

        static void BubbleSort<T>(T[] index, Campare<T> comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < index.Length - 1; i++)
            {
                for (j = 0; j < index.Length - (i + 1); j++)
                {
                    if (comparer(index[j], index[j + 1]) > 0)
                    {
                        temp = index[j + 1];
                        index[j + 1] = index[j];
                        index[j] = temp;
                    }
                }
            }
        }
    }
}
