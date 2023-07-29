using System;

namespace _20221017
{
    /*internal abstract class Shape
    {
        public abstract float GetArea();
    }

    class Square : Shape
    {
        float _size;

        public Square(float size)
        {
            _size = size;
        }

        public override float GetArea()
        {
            return _size * _size;
        }
    }

    class Triangle : Shape
    {
        float _size;

        public Triangle(float size)
        {
            _size = size;
        }

        public override float GetArea()
        {
            return (_size * _size) / 2;
        }
    }*/

    /*abstract class Product
    {
        public static int serial = 0;

        public string SerialID
        {
            get
            {
                return serial.ToString() + 1;
            }

        }

        public abstract DateTime ProductDate
        {
            get; set;
        }

    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get; set;
        }

        public MyProduct(DateTime _ProductDate)
        {
            ProductDate = _ProductDate;
        }
    }*/

    /*class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public NamedValue(string _name, string _value)
        {
            Name = _name;
            Value = _value;
        }

    }*/

    /*static void Main(string[] args)
    {
        #region 첫번째 과제
        *//*Square squ = new Square(3);
        Triangle tri = new Triangle(3);

        Console.WriteLine($"사각형의 넓이 : {squ.GetArea()}");
        Console.WriteLine($"사각형의 넓이 : {tri.GetArea()}");*//*
        #endregion

        #region 두번째 과제
        *//*MyProduct myProduct = new MyProduct(DateTime.Now);
        Console.WriteLine(myProduct.SerialID);
        Console.WriteLine(myProduct.ProductDate);*//*
        #endregion


        NamedValue name = new NamedValue("이름", "윤희수");
        NamedValue height = new NamedValue("키", "172");
        NamedValue weight = new NamedValue("몸무게", "56");

        Console.WriteLine(name.Name);
        Console.WriteLine(name.Value);
        Console.WriteLine(height.Name);
        Console.WriteLine(height.Value);
        Console.WriteLine(weight.Name);
        Console.WriteLine(weight.Value);
    }*/
}
