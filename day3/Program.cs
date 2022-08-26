using System;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:
                    student stu = new student();
                    stu.id = int.Parse(Console.ReadLine());
                    stu.name = Console.ReadLine();
                    stu.email = Console.ReadLine();
                    break;

                case 2:
                    Teacher tea = new Teacher();
                    tea.id = int.Parse(Console.ReadLine());
                    tea.name = Console.ReadLine();
                    tea.email = Console.ReadLine();
                    break;
            }
        }
    }
}
