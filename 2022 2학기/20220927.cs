using System;

namespace _20220927
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        #region 구조체 배열
        struct Student
        {
            public int id;
            public string name;
            public DateTime bDay;
        }

        public static void Print()
        {
            Student s2 = new Student();
            s2.id = 10102;
            s2.name = "윤희수";
            s2.bDay = new DateTime(1234, 12, 12);
            Console.WriteLine($"학번은 {s2.id}이거구 이름은 {s2.name}이거구 생일이 {s2.bDay}이거에요 히히\n");

            Student[] students = new Student[3]; // 구조체 배열 선언

            students[0].id = 10102;
            students[1].id = 10102;
            students[2].id = 10103;

            students[0].name = "윤희수";
            students[1].name = "경동엽";
            students[2].name = "강민성";

            students[0].bDay = new DateTime(2006, 11, 14);
            students[1].bDay = new DateTime(2007, 01, 29);
            students[2].bDay = new DateTime(2006, 01, 16);

            for (int i = 0; i < students.Length; i++)
                Console.WriteLine($"학번: {students[i].id} \n이름: {students[i].name} \n생일(아님): {students[i].bDay}\n");
        }
        #endregion
    }*/

    /*internal class Program
    {
        static void Main(string[] args)
        {
            #region 매개변수로 구조체 넘기기
            Member member = new Member();
            member.name = "홍길동";
            member.age = 17;
            print(member.name, member.age);

            Member m = new Member();
            m.name = "윤희수";
            m.age = 2147483647;
            print(m.name, m.age);
            #endregion
        }

        #region 매개변수로 구조체 넘기기
        public struct Member
        {
            public string name;
            public int age;
        }

        public static void print(string str, int it)
        {
            Console.WriteLine($"{str}\n{it}");
        }

        public static void print(Member member)
        {
            Console.WriteLine($"{member.name}\n{member.age}");
        }
        #endregion
    }*/

    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan dDay = Convert.ToDateTime("2022-12-25") - DateTime.Now;
            Console.WriteLine((int)dDay.TotalDays);

            TimeSpan bDay = Convert.ToDateTime("2006-11-14") - DateTime.Now;
            Console.WriteLine((int)bDay.TotalDays * -1);
        }
    }
}