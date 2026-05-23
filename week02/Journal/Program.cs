using System;

class Program
{
    static void Main(string[] args)
    {
// =====================================================
// Create reference object
// =====================================================

        Reference reference =
            new Reference("John", 3, 16);

// =====================================================
// Create scripture object
// =====================================================

        Scripture scripture =
            new Scripture(
                reference,
                "For God so loved the world that he gave his only begotten Son"
            );

// =====================================================
// Program control
// =====================================================

        bool running = true;

// =====================================================
// Main program loop
// =====================================================

        while (running)
        {
// ----------- Clear console -----------

            Console.Clear();

// ----------- Display scripture -----------

            Console.WriteLine(
                scripture.GetDisplayText()
            );

// ----------- Check if all words hidden -----------

            if (scripture.IsCompletelyHidden())
            {
                running = false;
                break;
            }

// ----------- Ask user -----------

            Console.WriteLine();
            Console.WriteLine(
                "Press Enter to continue or type 'quit'"
            );

            Console.Write("> ");

            string input = Console.ReadLine();

// ----------- Quit program -----------

            if (input.ToLower() == "quit")
            {
                running = false;
            }

// ----------- Hide random words -----------

            else
            {
                scripture.HideRandomWords(3);
            }
        }
// =====================================================
// End message
// =====================================================

        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}