using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {        
        Reference reference = new Reference("Alma", 29, 1);
        Scripture scripture = new Scripture(reference, "O that I were an angel, and could have the wish of mine heart, that I might go forth and speak with the trump of God, with a voice to shake the earth, and cry repentance unto every people");
        Console.Clear();        
        scripture.Display();
                
        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWords(1); 
            Console.Clear();
            scripture.Display();
        }
        Console.WriteLine("");
        Console.WriteLine("I hope I've helped you memorize it.");
        Console.WriteLine("");
    }
}