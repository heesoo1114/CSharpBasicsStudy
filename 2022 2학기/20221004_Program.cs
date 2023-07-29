using System;

namespace _20221004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string unique;

            unique = Guid.NewGuid().ToString();

            Console.WriteLine(unique);*/

            Developer d = new Developer();
            Art a = new Art();
            ProjectManager p = new ProjectManager();

            d.Work();
            a.Work();
            p.Work();
        }
    }

    class Developer : IPerson
    {
        public void Work()
        {
            Console.WriteLine("개발을 합니다");
        }
    }

    class Art : IPerson
    {
        public void Work()
        {
            Console.WriteLine("도트 찍습니다");
        }
    }

    class ProjectManager : IPerson
    {
        public void Work()
        {
            Console.WriteLine("기획합니다");
        }
    }
}
