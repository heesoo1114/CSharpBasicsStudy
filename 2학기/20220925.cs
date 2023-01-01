using System;

namespace _20220925
{
    internal class Program
    {
        struct student
        {
            public int id;
            public string name;
            public DateTime Bday;
        }

        static void Main(string[] args)
        {
            // 1번 문제
            /*DateTime dt;

            if(DateTime.TryParse("2022-09-26", out dt))
            {
                Console.WriteLine(dt.ToString());
            }
            else
            {
                Console.WriteLine("날짜형으로 변환할 수 없다");
            }

            // 추가 문제
            if(DateTime.TryParse("2022-09-26", out DateTime myDate))
            {
                Console.Write(myDate.ToString());
            }*/

            student student = new student();
            student.id = 10111;
            student.name = "윤희수";
            student.Bday = new DateTime(2006, 11, 14);

            // Console.WriteLine("학번은 " + student.id + " 이름은 " + student.name + " 생일은 "+ student.Bday + "입니다");
            Console.WriteLine($"학번은 {student.id} 이름은 {student.name} 생일은 {student.Bday} 입니다.");
        }
    }
}
