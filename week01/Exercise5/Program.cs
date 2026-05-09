using System;

class Program
{
    static void Main(string[] args)
    {
//----------- Welcome message -----------
        DisplayWelcome();

//----------- Ask for user name -----------
        string userName = PromptUserName();

//----------- Ask for favorite number -----------
        int favoriteNumber = PromptUserNumber();

//----------- Calculate square number -----------
        int squaredNumber = SquareNumber(favoriteNumber);

//----------- Display final result -----------
        DisplayResult(userName, squaredNumber);
    }

//----------- Function: Welcome message -----------
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

//----------- Function: Ask for user name -----------
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");

        string name = Console.ReadLine();

        return name;
    }

//----------- Function: Ask for favorite number -----------
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        int number = int.Parse(Console.ReadLine());

        return number;
    }

//----------- Function: Square the number -----------
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

//----------- Function: Display the result -----------
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}