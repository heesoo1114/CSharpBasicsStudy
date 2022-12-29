using System;
using System.Collections.Generic;

namespace _20220531
{
    internal class Program
    {
        class Hero
        {

            public string name;
            public double expereince;
            public void walk(string walk)
            {
                if (walk == "walk")
                {
                    Console.WriteLine("걸어서 이동 중입니다.");
                }

            }
            public void Run(string Run)
            {
                if (Run == "Run")
                {
                    Console.WriteLine("뛰어가는 중입니다");
                }
            }
            public string fire(string fire)
            {
                if (fire == "Fire")
                {
                    return "필살기!!";
                }
                return fire;
            }

        }
        static void Main(string[] args)
        {
            List<Hero> Heros = new List<Hero>()
            {
                new Archer(), new Swordsman(),new Archer(),new Swordsman(),new Archer(),
                new Swordsman(), new Archer(),new Swordsman(),new Archer(),new Swordsman()
            };
            foreach (var item in Heros)
            {
                item.walk("walk");
                item.Run("Run");
                item.fire("Fire");

                if (item is Archer)
                {
                    ((Archer)item).go("go");
                }
                else if (item is Swordsman)
                {
                    ((Swordsman)item).swordAttack();
                }

                var Archer = item as Archer;
                if(Archer != null)
                {
                    Archer.go("go");
                }
                
                var Swordsman = item as Swordsman;
                if (Swordsman != null)
                {
                    Swordsman.swordAttack();
                }
                
            }
        }
        class Swordsman : Hero
        {
            public string sword;


            public void swordAttack() { Console.WriteLine("찌르기!!"); }
        }
        class Archer : Hero
        {
            public int arrow;
            public int bow;
            public void go(string go)
            {
                if (go == "go")
                {
                    Console.WriteLine("활쏘는 중입니다.");
                }
            }

        }
    }
}