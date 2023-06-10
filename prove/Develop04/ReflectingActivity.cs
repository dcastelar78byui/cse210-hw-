using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) :base(name,description,duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." 
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" 
        };

    }

    public override void DisplayStartMessage()
    {
        base.DisplayStartMessage();
        Console.WriteLine("Consider the following prompt:");
    }

    public override void PausingWhileShowingSpinner()
    {
        //base.PausingWhileShowingSpinner();
        List<string> animationSpinner = new List<string>();
        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

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

    public override void DisplayEndActivity()
    {
        base.DisplayEndActivity();
    }

    public void InitReflectingActivity()
    {
        DisplayStartMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt($" --- {prompt} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press ENTER to continue");
        Console.ReadLine();        

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        PausingWhileShowingCountdown();
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            string question = GetRandomQuestionPrompt();
            DisplayPrompt(question);
            PausingWhileShowingSpinner();
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

    private string GetRandomQuestionPrompt()
    {
        Random random1 = new Random();
        int a = _questions.Count;
        int randomIndex1 = random1.Next(a);
        return _questions[randomIndex1];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    private void DisplayQuestion(string question)
    {
        Console.WriteLine(question);
    }
}