using System;

namespace _220524
{
    internal class Program
    {
        class Archer
        {
            private string name;
            private int arrow;
            private int bow;
            private float exp;

            public string Name
            {
                get { return name; }
                set { this.name = value; }
            }
            public int Arrow
            {
                get { return arrow; }
                set { this.arrow = value; }
            }
            public int Bow
            {
                get { return bow; }
                set { this.bow = value; }
            }
            public float Exp
            {
                get { return exp; }
                set { this.exp = value; }
            }
        }

        static void Main(string[] args)
        {
            Archer archer = new Archer();
        }
    }
}