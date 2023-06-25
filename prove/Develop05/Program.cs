using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop0511 World!");
        Console.WriteLine("\nThe Eternal Quest Program ");
        GoalData goalData = new GoalData();
        Console.Write($"\n You have: {goalData.GetPoints()} points! ");


        
        MainMenu mainMenu = new MainMenu(goalData);

        mainMenu.Show();

        string textOption = Console.ReadLine();
        int option = int.Parse(textOption);
              
        switch (option)
        {
            case 1:
                CreateNewGoal(goalData);
                break;
            
            case 2:
                ListGoals(goalData);
                break;
            case 3:
                SaveGoals(goalData);
                break;
            case 4:
                LoadGoals(goalData);
                break;
            case 5:
                RecordEvent(goalData);
                break;
            case 6:
                break;
            default:
                Console.WriteLine("Invalid option. Please enter a valid number.");
                break;
        }
    }

    private static void CreateNewGoal(GoalData goalData)
    {   
        GoalMenu goalMenu = new GoalMenu(goalData);
        goalMenu.Show();
        
        string textOption = Console.ReadLine();
        int option = int.Parse(textOption);
              
        switch (option)
        {
            case 1:
                SimpleGoalF(goalData);
                break;
                
            case 2:
                EternalGoalF(goalData);
                break;
                
            case 3:
                ChecklistGoalF(goalData);
                break;
                
            default:
                Console.WriteLine("Invalid option. Please enter a valid number.");
                break;
        }
        
       
    }

    private static void SimpleGoalF(GoalData goalData)
    {
        Console.WriteLine("\nCreating a Simple goal:");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Goal points: ");
        string textPoints = Console.ReadLine();
        int points = int.Parse(textPoints);

        Goal newGoal = new SimpleGoal(name, description, points);
        goalData.AddGoal(newGoal);    
    }

    private static void EternalGoalF(GoalData goalData)
    {
        Console.WriteLine("\nCreating a Simple goal:");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Goal points: ");
        string textPoints = Console.ReadLine();
        int points = int.Parse(textPoints);

        Goal newGoal = new EternalGoal(name, description, points);
        goalData.AddGoal(newGoal);    
    }

    private static void ChecklistGoalF(GoalData goalData)
    {
        Console.WriteLine("\nCreating a Simple goal:");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Goal points: ");
        string textPoints = Console.ReadLine();
        int points = int.Parse(textPoints);

        Console.Write("Times: ");
        string textTimes = Console.ReadLine();
        int times = int.Parse(textTimes);

        Console.Write("Bonus points: ");
        string textBonus = Console.ReadLine();
        int bonus = int.Parse(textBonus);


        Goal newGoal = new ChecklistGoal(name, description, points, times,bonus);
        goalData.AddGoal(newGoal);    
    }

    private static void ListGoals(GoalData goalData)
    {
        goalData.GetGoalNames();  //Not completed
	}

        
    

    private static void SaveGoals(GoalData goalData1)
    {
        Console.Write("Enter file name to save: ");
        string fileName = Console.ReadLine();
        goalData1.Save(fileName);
        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals(GoalData goalData1)
    {
        Console.Write("Enter file name to load: ");
        string fileName = Console.ReadLine();
        goalData1.Load(fileName);
        Console.WriteLine("Goals loaded successfully.");
    }

    private static void RecordEvent(GoalData goalData)
    {
        
    }
}

//

