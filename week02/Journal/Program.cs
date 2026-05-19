using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ----------- Create journal object -----------
        Journal journal = new Journal();

        // ----------- Create prompts list -----------
        List<string> prompts = CreatePrompts();

        // ----------- Create checklist -----------
        Dictionary<string, List<string>> checklist = CreateChecklist();

        // ----------- Random generator -----------
        Random randomGenerator = new Random();

        // ----------- Program control -----------
        bool running = true;

        // ----------- Welcome message -----------
        Console.WriteLine("Welcome to the Journal Program!");

        // ----------- Main loop -----------
        while (running)
        {
            // ----------- Display menu -----------
            DisplayMenu();

            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            // ----------- Option 1: Write -----------
            if (choice == "1")
            {
                WriteEntry(journal, prompts, randomGenerator);
            }

            // ----------- Option 2: Display -----------
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            // ----------- Option 3: Load -----------
            else if (choice == "3")
            {
                LoadJournal(journal);
            }

            // ----------- Option 4: Save -----------
            else if (choice == "4")
            {
                SaveJournal(journal);
            }

            // ----------- Option 5: Checklist -----------
            else if (choice == "5")
            {
                DisplayChecklist(checklist);
            }

            // ----------- Option 6: Quit -----------
            else if (choice == "6")
            {
                running = false;
            }

            // ----------- Invalid option -----------
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    // =====================================================
    // Function: Display menu
    // =====================================================

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Checklist");
        Console.WriteLine("6. Quit");
    }

    // =====================================================
    // Function: Create prompts list
    // =====================================================

    static List<string> CreatePrompts()
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        return prompts;
    }

    // =====================================================
    // Function: Create checklist
    // =====================================================

    static Dictionary<string, List<string>> CreateChecklist()
    {
        Dictionary<string, List<string>> checklist =
            new Dictionary<string, List<string>>();

        // ----------- Personal -----------
        checklist["Personal"] = new List<string>()
        {
            "Make the bed",
            "Drink 2 liters of water",
            "Take vitamins",
            "Eat a healthy diet",
            "Exercise"
        };

        // ----------- Academic -----------
        checklist["Academic"] = new List<string>()
        {
            "Study the program",
            "Do the class exercises"
        };

        // ----------- Professional -----------
        checklist["Professional"] = new List<string>()
        {
            "Read the meeting minutes",
            "Catalog received material",
            "Check purchase orders"
        };

        // ----------- Spiritual -----------
        checklist["Spiritual"] = new List<string>()
        {
            "Morning prayer",
            "Morning Book of Mormon reading",
            "Come, Follow Me study",
            "Evening prayer",
            "Evening Book of Mormon reading"
        };

        return checklist;
    }

    // =====================================================
    // Function: Write new journal entry
    // =====================================================

    static void WriteEntry(
        Journal journal,
        List<string> prompts,
        Random randomGenerator)
    {
        // ----------- Get random prompt -----------
        int randomNumber = randomGenerator.Next(prompts.Count);

        string prompt = prompts[randomNumber];

        // ----------- Display prompt -----------
        Console.WriteLine(prompt);
        Console.Write("> ");

        // ----------- Read user response -----------
        string response = Console.ReadLine();

        // ----------- Create entry object -----------
        Entry newEntry = new Entry();

        // ----------- Fill entry data -----------
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        // ----------- Add entry to journal -----------
        journal.AddEntry(newEntry);
    }

    // =====================================================
    // Function: Save journal
    // =====================================================

    static void SaveJournal(Journal journal)
    {
        Console.Write("What is the filename? ");

        string file = Console.ReadLine();

        journal.SaveToFile(file);
    }

    // =====================================================
    // Function: Load journal
    // =====================================================

    static void LoadJournal(Journal journal)
    {
        Console.Write("What is the filename? ");

        string file = Console.ReadLine();

        journal.LoadFromFile(file);
    }

    // =====================================================
    // Function: Display checklist
    // =====================================================

    static void DisplayChecklist(
        Dictionary<string, List<string>> checklist)
    {
        Console.WriteLine();
        Console.WriteLine("===== DAILY CHECKLIST =====");
        Console.WriteLine();

        foreach (var category in checklist)
        {
            Console.WriteLine(category.Key);

            foreach (string task in category.Value)
            {
                Console.WriteLine($"[ ] {task}");
            }

            Console.WriteLine();
        }
    }
}