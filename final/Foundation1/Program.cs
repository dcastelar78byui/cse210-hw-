using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine("");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video BYU-I 1", "Author 1", 60);
        video1.AddComment("User 1", "Comment 1");
        video1.AddComment("User 2", "Comment 2");
        videos.Add(video1);

        Video video2 = new Video("Video BYU-I 2", "Author 2", 90);
        video2.AddComment("User 3", "Comment 3");
        video2.AddComment("User 4", "Comment 4");
        video2.AddComment("User 5", "Comment 5");
        videos.Add(video2);

        Video video3 = new Video("Video BYU-I 3", "Author 3", 120);
        video3.AddComment("User 6", "Comment 6");
        video3.AddComment("User 7", "Comment 7");
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

        Console.ReadLine();
    }


    
}