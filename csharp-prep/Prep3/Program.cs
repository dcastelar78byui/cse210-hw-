using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        // create number random
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,100);

        int userNumber = -1;

        while(userNumber != randomNumber)
        {
            Console.Write("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());

            if (randomNumber > userNumber)
            {
                Console.WriteLine(" Higher");
            }
            else if (randomNumber < userNumber)
            {
                Console.WriteLine(" Lower");
            }
            else
            {
                Console.WriteLine(" You guessed it !!!");
            }
        }

    }
}