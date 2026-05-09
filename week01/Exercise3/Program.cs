using System;

class Program
{
    static void Main(string[] args)
    {
//------------Ask for the magic number---------
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

//-----------Ask for the first guess------------
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

//----------Loop until the guess is correct-------
        while (guess != magicNumber)
        {
//--------------If the guess is lower---------------
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

//-------------If the guess is higher---------------
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

//-------------Ask again-------------------------
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

//------------------Correct guess-------------------
        Console.WriteLine("You guessed it!");
    }
}