using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
// =====================================================
// ------------- Create list of videos -----------------
// =====================================================

        List<Video> videos = new List<Video>();

// =====================================================
// -------------------- Video 1 ------------------------
// =====================================================

        Video video1 =
            new Video(
                "Learn C# in 20 Minutes",
                "Programming Academy",
                1200
            );

        video1.AddComment(
            new Comment(
                "Maria",
                "Very helpful video!"
            )
        );

        video1.AddComment(
            new Comment(
                "John",
                "Thanks for explaining classes."
            )
        );

        video1.AddComment(
            new Comment(
                "Lucas",
                "Great tutorial!"
            )
        );

        videos.Add(video1);

// =====================================================
// --------------------- Video 2 -----------------------
// =====================================================

        Video video2 =
            new Video(
                "Object Oriented Programming",
                "Tech World",
                1500
            );

        video2.AddComment(
            new Comment(
                "Ana",
                "Excellent explanation."
            )
        );

        video2.AddComment(
            new Comment(
                "Pedro",
                "I finally understand abstraction."
            )
        );

        video2.AddComment(
            new Comment(
                "Sophia",
                "Very clear examples."
            )
        );

        videos.Add(video2);

// =====================================================
// ------------------- Video 3 -------------------------
// =====================================================

        Video video3 =
            new Video(
                "Learn Lists in C#",
                "Code Master",
                900
            );

        video3.AddComment(
            new Comment(
                "Carlos",
                "Lists are easier now."
            )
        );

        video3.AddComment(
            new Comment(
                "Julia",
                "Good examples."
            )
        );

        video3.AddComment(
            new Comment(
                "Emma",
                "Thank you!"
            )
        );

        videos.Add(video3);

// =====================================================
// --------------- Display all videos ------------------
// =====================================================

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine("==============================");

            Console.WriteLine(
                $"Title: {video.GetTitle()}"
            );

            Console.WriteLine(
                $"Author: {video.GetAuthor()}"
            );

            Console.WriteLine(
                $"Length: {video.GetLength()} seconds"
            );

            Console.WriteLine(
                $"Comments: {video.GetNumberOfComments()}"
            );

            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetPersonName()}: {comment.GetCommentText()}"
                );
            }
        }
    }
}