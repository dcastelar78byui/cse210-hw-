using System;
using System.IO;
using System.Collections.Generic;


 

class Program
{

    static List<Entry> journal = new List<Entry>();
    static List<string> prompts = new List<string>(); 
    static void Main(string[] args)
    {

  

        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();

        Console.WriteLine("Menu");
        Console.WriteLine("Options");

        int flag = 1;
        while (flag==1)
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
                    NewEntry();
                    break;
                case 2: 
                    DisplayJ();
                    break;
                case 3:
                    SaveJ();
                    break;
                case 4: 
                    LoadJ();
                    break;
                default :
                    Console.WriteLine("error de numero");
                    return;
                
            }
        }
    }       

    static void NewEntry() 
    {
            Console.WriteLine("Ha seleccionado New Entry");
            string prompt = RandomPrompt();
            Console.WriteLine(prompt);
            Console.Write("Answer: ");
            string answer = Console.ReadLine();
            
            Entry NewEntry = new Entry(prompt, answer);
            journal.Add(NewEntry);
            Console.WriteLine("Entry added!");  
        
    }
    static string RandomPrompt()
    {
        Console.WriteLine("Estoy en Random");
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }

        


    static void DisplayJ()
    {
        Console.WriteLine("Display Journal Entries:");
        foreach (Entry entry in journal)
        {
            Console.WriteLine(entry.ToString());
        }
    }

     static void SaveJ()
    {        
        Console.WriteLine("Save Journal");
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        JournalFileHandler.SaveJournalToFile(journal, filename);

        Console.WriteLine("Journal saved to file!");
    }

    static void LoadJ()
    {   
        Console.WriteLine("Load Journal");
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        List<Entry> loadedJournal = JournalFileHandler.LoadJournalFromFile(filename);
        journal = loadedJournal;

        Console.WriteLine("Journal loaded from file!");
    }

}
