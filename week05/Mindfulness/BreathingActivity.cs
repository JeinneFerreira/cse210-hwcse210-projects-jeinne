using System;

public class BreathingActivity : Activity
{
// ----------- Constructor -----------
// ----------- Creates a breathing activity ----------- 
    public BreathingActivity()
        : base(
              "Breathing",
              "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

// ----------- Run Activity -----------
// ----------- Runs the breathing exercise ----------- 
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
// ----------- Breathe In ----------- 
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);

// ----------- Breathe Out ----------- 
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(4);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}