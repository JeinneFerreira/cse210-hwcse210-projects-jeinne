using System;
using System.Threading;

public class Activity
{
// ----------- Attributes -----------
    private string _name;
    private string _description;
    protected int _duration;

// ----------- Constructor -----------
// ----------- Initializes the activity name and description ----------- 
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

// ----------- Starting Message -----------
// ----------- Displays activity information and asks for duration ----------- 
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

// ----------- Ending Message -----------
// ----------- Displays completion message ----------- 
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");

        ShowSpinner(5);
    }

/* ----------- Spinner Animation -----------
  ----------- Shows a rotating animation for a few seconds  -----------  */
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Length)
            {
                i = 0;
            }
        }
    }

/* ----------- Countdown Animation -----------
 ----------- Displays a countdown timer ----------- */
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}