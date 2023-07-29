using System;

namespace _20220324
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("당신의 이름은 " + name);



            Console.WriteLine(int.Parse("52"));
            //테스트 - Console.WriteLine(int.Parse("52").GetType());

            Console.WriteLine(float.Parse("273.93"));
            //테스트 - Console.WriteLine(float.Parse("273.93").GetType());
            Console.WriteLine(int.Parse("52") + float.Parse("273.93"));
            /* 테스트
            Console.WriteLine("273.93");
            Console.WriteLine("273.93".GetType());*/




            double number = 3.1415926535;
            Console.WriteLine(number.ToString("0.0000000"));
            Console.WriteLine(number.ToString("0.0000"));
            Console.WriteLine(number.ToString("0.0"));
        }
    }
}