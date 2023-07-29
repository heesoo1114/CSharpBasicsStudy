using System;

namespace _20220919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            int vx = 5, vy = 5;
            int rx, ry;
            NextPosition(a, b, vx, vy, out rx, out ry);
            Console.WriteLine(rx + " " + ry);

        }
        public static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx; ry = y + vy;
        }
    }
}
