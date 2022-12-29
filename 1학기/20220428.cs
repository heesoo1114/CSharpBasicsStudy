using System;
using System.Collections.Generic;

namespace _20220428
{
    
    
    class FirstClass
    {
        
        

    }

    class SecondClass
    {



    }
    
    internal class Program
    {




        static void Main(string[] args)
        {

            class ThirdClass
        {


        }

            List<int> list = new List<int>() { 52, 273, 32, 64};
            /*
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            */

            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem: " + item);
            }

           


        }
    }
}
