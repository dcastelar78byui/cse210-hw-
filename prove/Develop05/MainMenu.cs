using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class MainMenu : Menu
{
    private GoalData _goalData;

    public MainMenu(GoalData goalData) : base("Main Menu", new List<string> { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" }, "Enter option 1-6: ")
    {
       _goalData = goalData;
    }

    public override int Show()  
    {   
        Console.WriteLine("");
        Console.WriteLine(base._description);

        for (int i = 0; i < base._options.Count; i++)
        {
            Console.WriteLine($"[{i+1}] {base._options[i]}");
               
        }
    }
}

