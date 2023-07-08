using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("");

        DateTime activityDate = new DateTime(2023, 7, 6);
        int activityDuration = 30;

        Activity running = new Running(activityDate, activityDuration, 4.8);
        Console.WriteLine(running.GetSummaryMi());
        Console.WriteLine(running.GetSummaryKM());
        Console.WriteLine("");


        activityDuration = 60;
        Activity cycling = new Cycling(activityDate, activityDuration, 30);
        Console.WriteLine(cycling.GetSummaryMi());
        Console.WriteLine(cycling.GetSummaryKM());
        Console.WriteLine("");

        activityDuration = 40;
        Activity swimming = new Swimming(activityDate, activityDuration, 100);
        Console.WriteLine(swimming.GetSummaryMi());
        Console.WriteLine(swimming.GetSummaryKM());
        Console.WriteLine("");
    }
}