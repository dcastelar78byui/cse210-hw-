using System;

namespace games
{
    class Program18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prep1 World!");
            string name = "";
            string surname = "";
            Console.Write("What is your first name?.");
            name = Console.ReadLine();
            Console.Write("What is your last name?.");
            surname = Console.ReadLine();

            Console.WriteLine($"Your name is {surname}, {name} {surname}.");
        }
    }
}