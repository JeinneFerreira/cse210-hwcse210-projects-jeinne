//--------------code construction-----------

using System;

class Program
{
    static void Main(string[] args)

//---------Ask the user for the grade ---------
    {
        Console.Write("What is your grade percentage? ");

//---------Convert the text to a number-------
        string userInput = Console.ReadLine();

//--------Variable to store the letter grade------

        int grade = int.Parse(userInput);


// -------Variable to store the letter grade----
        string letter = "";

//-----------defining the notes in letters-----------

// -----------first part-------------
        if (grade >=90)
        {
            letter = "A";
        }

// -----------second part-------------
        else if (grade >=80)
        {
        letter = "B";
        }
// -----------third part-------------
        else if (grade >= 70)
        {
        letter = "C";
        }
// -----------part four-------------
        else if (grade >= 60)
        {
        letter = "D";
        }
// -----------fifth part-------------
        else
        {
        letter = "F";
        }
//--------Display the letter grade-----
        Console.WriteLine($"Your grade is {letter}");

//-------Determine if the student passed-------
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}
