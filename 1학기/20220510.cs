using System;

namespace _20220510
{
    class Archer
    {

        public string name;
        public int arrow;
        public int bow;
        public float expreience;
        
        private void walk(string  a)
        {
            if( a == "walk")
            {
            Console.WriteLine("걸어서 이동 중입니다.");
            }
        }
        public void run(string a)
        {
            walk(a);

            if ( a == "run")
            {   
                Console.WriteLine("뛰어가는 중입니다.");
            }
        }
        private void go(string a)
        {
            if( a == "go")
            {
                Console.WriteLine("활쏘는 중입니다.");
            }
            
        }
        public string fire(string a)
        {
            go(a);

            if (a == "fire")
            {
                return "필살기!!";
            }
            return "";
        }

    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Archer archer  = new Archer();
            archer.name = "윤희수";
            archer.arrow = 100;
            archer.bow = 100;
            archer.expreience = 78.91f;

            Console.WriteLine("Name : " + archer.name);
            Console.WriteLine("Arrow : " + archer.arrow);
            Console.WriteLine("Bow : " + archer.bow);
            Console.WriteLine("Expreience : " + archer.expreience);
            Console.WriteLine();

            archer.run("walk");
            archer.run("run");
            archer.fire("go");
            string a = archer.fire("fire");
            Console.WriteLine(a);
        }
    }
}      

                


