using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int choice = 9;
        while (choice != 4)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Activity Program.");
            Console.WriteLine("  1-Breathing Activity");
            Console.WriteLine("  2-Reflecting Activity");
            Console.WriteLine("  3-Listing Activity");
            Console.WriteLine("  4-Exit");
            Console.WriteLine("");
            Console.Write("Enter your choice(1-4):  ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InitBreathingActivity();
                    break;
                case 2:
                    InitReflectingActivity();
                    break;
                case 3:
                    InitListiningActivity();
                    break;
                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            
            }
        }
    }

    public static void InitBreathingActivity()
    {
        string act = "Breathing Activity";
        string descrip = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        int seconds = 10;

        BreathingActivity breathingActivity = new BreathingActivity(act,descrip,seconds);
        breathingActivity.StartBreathingActivity();
    }

    public static void InitReflectingActivity()
    {
        string act = "Reflecting Activity";
        string descrip = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int seconds = 10;

        ReflectingActivity reflectingActivity = new ReflectingActivity(act,descrip,seconds);
        reflectingActivity.InitReflectingActivity();
    }

    public static void InitListiningActivity()
    {
        string act = "Listining Activity";
        string descrip = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ";
        int seconds = 10;

        ListingActivity listingActivity = new ListingActivity(act,descrip,seconds);
        listingActivity.InitListiningActivity();
                        
    }




}