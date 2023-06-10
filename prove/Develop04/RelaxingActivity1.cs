using System;
using System.Collections.Generic;
using System.Media;


public class RelaxingActivity : Activity
{
     private string _playlist;

    public RelaxingActivity(string name, string description, int duration) :base(name,description,duration)
    {
        _playlist = @"prove\Develop04\the-last-piano-112677.mp3";
    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.WriteLine("Enjoy");            
    }

    public void StartRelaxingActivity()
    {
       DisplayStartMessage();
        
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(_duration);
       Console.WriteLine("Here I should be playing the relaxation music, but I don't know how to do it.");
       Console.WriteLine("the-last-piano-112677.mp3");
       while (DateTime.Now < endTime)
       
       {
        
        // Play Music

       }


       DisplayEndActivity(); 
    }

    
}