using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address address = new Address("100 Main St", "Provo", "Utah", "USA");

        Event conference = new Conference("Conference 1", "Conference Description 1 ", new DateTime(2023, 10, 06), new DateTime(2023, 10, 06, 9, 0, 0), address, "Speaker 1", 100);
        Console.WriteLine(conference.GetFullDetails());
        Console.WriteLine();

        Event reception = new Reception("Reception 1", "Reception Description 1", new DateTime(2023, 10, 07), new DateTime(2023, 10, 07, 10, 0, 0), address, "rsvp@gmail.com");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Event outdoorGathering = new OutdoorGathering("Gathering 1", "Gathering Description 1", new DateTime(2023, 10, 08), new DateTime(2023, 10, 08, 11, 0, 0), address, "Sunny");
        Console.WriteLine(outdoorGathering.GetFullDetails());


    }
}