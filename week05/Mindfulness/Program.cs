using System;

class Program
{
// ---------------------- Main Program ----------------------
    static void Main(string[] args)
    {
        int choice = 0;

// ------------------- Continue until user chooses Quit -----------------

        while (choice != 4)
        {
            Console.Clear();

            // Display menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

// ---------------------- Execute selected activity ----------------------


            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
            }

// ---------------------- Pause before returning to menu ----------------------

            if (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}