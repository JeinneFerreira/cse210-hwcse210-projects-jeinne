using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
// ----------- Reflection Prompts -----------
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

// ----------- Reflection Questions -----------
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "What is your favorite thing about this experience?"
    };

// ----------- Constructor -----------
    public ReflectionActivity()
        : base(
              "Reflection",
              "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

// ----------- Run Activity -----------
// ----------- Displays a prompt and reflection questions ----------- 
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

// ----------- Display random prompt ----------- 
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind press Enter.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder each of the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();

// ----------- Display random question ----------- 
            Console.Write($"> {_questions[random.Next(_questions.Count)]} ");

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}