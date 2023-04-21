using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int userIntN = -1;
        string userResponse ="";
        int sumList = 0;
        float promList = 1f;
        int maxList = 0;

        while (userIntN != 0)
        {
            Console.Write("Enter a number (0 to quiet): ");
            userResponse = Console.ReadLine();
            userIntN = int.Parse(userResponse);

            if (userIntN != 0)
            {
                numbers.Add(userIntN);
            }
                        
        }
        // sum
        foreach(int number in numbers)
        {
            sumList = sumList + number;
        }

        // average
        promList = ((float)sumList) / numbers.Count;
        
        //Max
        foreach (int number in numbers)
        {
            if (number > maxList)
            {
                maxList = number;

            }
        }

        Console.WriteLine($"The Sum is: {sumList} ");
        Console.WriteLine($"The Average is: {promList} ");
        Console.WriteLine($"The largest number is: {maxList} ");





    }
}