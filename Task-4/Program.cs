using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.WriteLine("Enter your birthdate:");
            string birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", birthdate);
        }
    }
}
