using System;

namespace _20220512
{
    class Program
    {

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
        }

        static void Main(string[] args)
        {
            Archer archerA = new Archer("윤희수", 10, 10, 5.2f);

            Console.WriteLine(archerA.arrow + " " + archerA.expreince);
        }

    }
}

