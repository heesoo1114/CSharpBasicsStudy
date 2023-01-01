using System;

namespace _20220915
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NickName nick = new NickName();
            nick["안형주"] = "려차와 오노조";
            Console.WriteLine(nick["안형주"]);
        }   
    }
}
