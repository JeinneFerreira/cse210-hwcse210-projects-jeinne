using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
// ----------- Listing Prompts -----------
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

// ----------- Constructor -----------
    public ListingActivity()
        : base(
              "Listing",
              "This activity will help you reflect on the good things in your life.")
    {
    }

// ----------- Run Activity -----------
// ---------------------- Allows the user to list as many items as possible ----------------------
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

// ---------------------- Display random prompt ----------------------


        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");

        ShowCountdown(5);

        Console.WriteLine();

// ---------------------- Store user responses ----------------------


        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

// ---------------------- Display total items entered ----------------------


        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        DisplayEndingMessage();
    }
}