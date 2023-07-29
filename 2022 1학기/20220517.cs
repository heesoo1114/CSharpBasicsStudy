using System;
using System.Threading;

namespace _0517and0519
{
    class Program
    {
        /*
        class Archer
        {
            public Archer() { }
            Archer hideen = new Archer();

            class a
            {
                Archer hidden = new Archer();
            }
        }

        static void Main(string[] args)
        {
            Archer hidden = new Archer();
        }
        */


        /*
        class Archer
        {
            public static int counter = 0;
            public string name;
            public int arrow;
            public int bow;
            public float expreince;
            static int id;

            public Archer(string name, int arrow, int bow, float expreince)
            {

                Archer.counter = counter + 1;
                Archer.id = counter;
                this.name = name;
                this.arrow = arrow;
                this.bow = bow;
                this.expreince = expreince;


            }

            ~Archer()
            {
                Console.WriteLine(DateTime.Now + "에 소멸자 호출됨");
            }


            static void Main(string[] args)
            {
                Test();
                GC.Collect();
                Thread.Sleep(1000);
            }

            static void Test()
            {
                Archer bow = new Archer("archer", 3, 4, 5.0f);
            }

        }*/
    }
}








