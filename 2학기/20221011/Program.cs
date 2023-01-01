using System;
using System.Collections.Generic;

namespace _20221011
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(new Good());
            Car car2 = new Car(new Bad());
            car1.Run();
            car2.Run();
        }
    }

    class Good : Ibattery
    {
        public string GetName()
        {
            return "Good";
        }
    }

    class Bad : Ibattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }

    class Car
    {
        Ibattery _battery;

        public Car(Ibattery battery)
        {
            _battery = battery;
        }

        public void Run()
        {
            Console.WriteLine(_battery.GetName());
        }
    }*/

    /*internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Yelp();
        }
    }

    class Dog : IAnimal, IDog
    {
        public void Eat()
        {
            Console.WriteLine("먹다");
        }

        public void Yelp()
        {
            Console.WriteLine("짖다");
        }
    }*/
    public class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}:{Price}";
        }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo((obj as Product).Price);
        }
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("고구마", 1500));
            list.Add(new Product("사과", 2400));
            list.Add(new Product("바나나", 1000));
            list.Add(new Product("배", 3000));

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}
