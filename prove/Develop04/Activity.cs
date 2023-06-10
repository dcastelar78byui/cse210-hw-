using System;
using System.Collections.Generic;


public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartMessage()
    {
        int sec;
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine($"  {_description}");
        Console.WriteLine("");
        Console.Write("Duration in seconds?:");
        sec = Convert.ToInt32(Console.ReadLine());
        SetDurationInSeconds(sec);
        Console.WriteLine("");
        Thread.Sleep(2000);
    }

    public virtual void PausingWhileShowingSpinner()
    {
        //Console.WriteLine("pausing while showing spinner");
                /*
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        */
        List<string> animationSpinner = new List<string>();
        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int j = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationSpinner[j];
            //Console.WriteLine("");
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            j++;

            if (j>= animationSpinner.Count)
            {
                j=0;
            }
        }
        
    }

    public virtual void DisplayEndActivity()
    {
        Console.WriteLine("Excellent job");
        Thread.Sleep(2000);
        Console.WriteLine($"You complete {_activityName} duration: {_duration} seconds.");
        Thread.Sleep(2000);
    }

    public virtual void PausingWhileShowingCountdown()
    {
        Console.Write("....");

        for (int l = 5; l>0; l--)
        {
            Console.Write($"{l}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetDurationInSeconds(int duration)
    {
        _duration = duration;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
}