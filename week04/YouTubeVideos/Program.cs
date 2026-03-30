using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful explanation."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing!"));

        Video video2 = new Video("Top 10 Programming Tips", "DevWorld", 450);
        video2.AddComment(new Comment("David", "Awesome tips."));
        video2.AddComment(new Comment("Emma", "This helped my coding."));
        video2.AddComment(new Comment("Frank", "Nice video!"));

        Video video3 = new Video("Understanding OOP", "TechGuru", 720);
        video3.AddComment(new Comment("Grace", "Abstraction finally makes sense!"));
        video3.AddComment(new Comment("Henry", "Very clear explanation."));
        video3.AddComment(new Comment("Isabel", "Loved this lesson."));

        Video video4 = new Video("Data Structures Explained", "CS Academy", 800);
        video4.AddComment(new Comment("Jack", "Stacks and queues explained well."));
        video4.AddComment(new Comment("Karen", "Very informative."));
        video4.AddComment(new Comment("Leo", "Subscribed!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}