using System;

public class Journal
{
    public static List<Entry> entries = new List<Entry>();
    public static List<string> _promptList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most important news today in Argentina?",
        "What was the most important news today in the world?",
        "What is the exchange rate of the US Dollar today?",
        "What is the price of Bitcoin?"
    };

     public static List<string> _sundayList = new List<string>  //questions in case it is Sunday
     {
        "most impactful message from sacramental meeting", "most impactful message from classes",
        "any thoughts"

     };   

    public static void NewEntry() 
    {
            Console.WriteLine("You Choose New Entry");

            string prompt;
            string answer;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            { 
                prompt = RandomPromptSunday(); // Random prompt on Sunday
                Console.WriteLine(prompt);
                Console.Write("Answer: ");
                answer = Console.ReadLine();                
            }
            else 
            {
                prompt = RandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Answer: ");
                answer = Console.ReadLine();
            }
            Entry newEntry = new Entry(prompt, answer);
            entries.Add(newEntry);
            Console.WriteLine("Entry added");  
        
    }

        public static string RandomPromptSunday()
    {
        Console.WriteLine("Its Sunday");
        Random rand = new Random();
        int index = rand.Next(_sundayList.Count);
        return _sundayList[index];
    }
    public static string RandomPrompt()
    {
        Console.WriteLine("Random");
        Random rand = new Random();
        int index = rand.Next(_promptList.Count);
        return _promptList[index];
    }






     public static void DisplayJ()
    {
        Console.WriteLine("Display Journal Entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public static void SaveJ()
    {        
        Console.WriteLine("Save Journal");
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._prompt}#{e._date.ToString()}#{e._response}");
            }
        
        }

        Console.WriteLine("Journal saved");
    }

    public static void LoadJ()
    {   
        Console.WriteLine("Load Journal");
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        


        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string answer = parts[0];
            string date = parts[1];
            string response = parts[2];

            Entry newEntry = new Entry( answer,response);
            newEntry._date = DateTime.Parse(date);
            entries.Add(newEntry);
            
        }
        Console.WriteLine("Journal loaded");
    }

    
}
