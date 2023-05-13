using System;
using System.IO;
using System.Collections.Generic;


 

class Program
{
    
    static void Main(string[] args)
    {  

        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();
        
        Console.WriteLine("Menu");
        Console.WriteLine("Options");

        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            string userOption = Console.ReadLine();
            int option = int.Parse(userOption);

            switch (option) {
                case 1: 
                    Journal.NewEntry();
                    break;
                case 2: 
                    Journal.DisplayJ();
                    break;
                case 3:
                    Journal.SaveJ();
                    break;
                case 4: 
                    Journal.LoadJ();
                    break;

                case 5: 
                    break;

                default :
                    Console.WriteLine("Error");
                    return;
                
            }
        }
    }  

}     
