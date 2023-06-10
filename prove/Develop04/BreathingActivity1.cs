using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    private List<string> _messageIn;
    private List<string> _messageOut;

    public BreathingActivity(string name, string description, int duration) :base(name,description,duration)
    {
        _messageIn = new List<string>{"Breathe in","Inhale slowly"};
        _messageOut = new List<string>{"Breathe out","Exhale Slowly"};
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.WriteLine("Clear your mind");            
    }

    public override void PausingWhileShowingSpinner()
    {
        base.PausingWhileShowingSpinner();
    }

    public override void DisplayEndActivity()
    {
        base.DisplayEndActivity();
    }


    public void StartBreathingActivity()
    {
       DisplayStartMessage();
        
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(_duration);

       while (DateTime.Now < endTime)
       
       {
        DisplayRandomBreathInMessage();
        PausingWhileShowingCountdown();

        Console.WriteLine("");

        DisplayRandomBreathOutMessage();
        PausingWhileShowingCountdown();

        Console.WriteLine("");

       }


       DisplayEndActivity(); 
    }

    private void DisplayRandomBreathInMessage()
    {
        Random random = new Random();
        int a = _messageIn.Count;
        int randomIndex = random.Next(a);
        Console.WriteLine(_messageIn[randomIndex]);

    }

    private void DisplayRandomBreathOutMessage()
    {
        Random random = new Random();
        int a = _messageOut.Count;
        int randomIndex = random.Next(a);
        Console.WriteLine(_messageOut[randomIndex]);
    }
}