
using System;

namespace _0602
{
    internal class Program
    {
        
        class Hero
        {
            public Hero()
            {
                Console.WriteLine("hero 클래스의 생성자");
            }
        }

        class Archer : Hero
        {
            public Archer()
            {
                Console.WriteLine("arher 클래스의 생성자");
            }
        }
        
        static void Main(string[] args)
        {
            Archer archer = new Archer();
        }
    }
}


        
