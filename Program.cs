using System;

namespace GitTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int age = 0;

            age = Console.Read();

            Console.WriteLine($"Wow, you're old ({age})");
        }
    }
}
