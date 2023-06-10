using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _activitiesResponseList;

    public ListingActivity(string name, string description, int duration) : base(name, description,duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?" 
         
        };

        _activitiesResponseList = new List<string>();
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.WriteLine("Think");
        Thread.Sleep(2000);
    }

    public override void PausingWhileShowingSpinner()
    {
        base.PausingWhileShowingSpinner();
    }

    public override void DisplayEndActivity()
    {
        //base.DisplayEndActivity();
        int nList = _activitiesResponseList.Count;
        Console.WriteLine($"You listed {nList}");
    }

    public void InitListiningActivity()
    {
        DisplayStartMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        
        Console.WriteLine("You may begin in");
        string r;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            r = Console.ReadLine();
            _activitiesResponseList.Add(r);
        }
        
        DisplayEndActivity();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int a = _prompts.Count;
        int randomIndex = random.Next(a);
        return _prompts[randomIndex];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }
}