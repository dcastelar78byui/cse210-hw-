using System;

public class Resume
{
    public string _name;
    // inicializacion de la lista //
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs Realizados:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}