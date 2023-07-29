using System;

namespace _20220526
{
    internal class Program
    {
        class SwordsMan
        {
            string name;
            string sword;
            float experience;

            public void Walk(string walk)
            {
                if (walk == "Walk")
                {
                    Console.WriteLine("걸어서 이동 중입니다.");
                }
            }

            public void Run(string run)
            {
                if (run == "Run")
                {
                    Console.WriteLine("뛰어가는 중입니다.");
                }
            }

            public string Fire(string fire)
            {
                if (fire == "Fire")
                {
                    return "필살기!";
                }
                return null;
            }

            public void sting()
            {
                Console.WriteLine("찌르기!!");
            }
        }

        class Archer
        {
            public string name;
            public int arrow;
            public int bow;
            public float experience;

            private void walk(string walk)
            {
                if (walk == "walk")
                {
                    Console.WriteLine("걸어서 이동 중입니다.");
                }
            }

            public void run(string run)
            {
                if (run == "run")
                {
                    Console.WriteLine("뛰어가는 중입니다");
                }
                else
                    walk(run);
            }

            private void go(string go)
            {
                if (go == "go")
                {
                    Console.WriteLine("활쏘는 중입니다");
                }
            }

            public string fire(string fire)
            {
                if (fire == "fire")
                {
                    return "필살기";
                }
                else
                    go(fire);
                return " ";
            }
        }

    }
}