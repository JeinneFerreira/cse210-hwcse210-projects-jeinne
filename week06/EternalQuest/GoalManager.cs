using System;
using System.Collections.Generic;

// Controls the program and manages all goals.
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // Main program loop.
    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            // Display the current score.
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            // Display menu options.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoals();
                    break;

                case 3:
                    RecordEvent();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }

    // Creates a new goal based on user input.
    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(
                new ChecklistGoal(
                    name,
                    desc,
                    points,
                    target,
                    bonus));
        }
    }

    // Displays all goals currently stored.
    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Records progress for a selected goal.
    private void RecordEvent()
    {
        ListGoals();

        Console.Write("Goal #: ");
        int goal = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[goal].RecordEvent();

        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }
}


//