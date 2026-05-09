using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

//----------Ask for numbers----------------
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

//-----------------Calculate sum--------------------
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
//--------------Calculate average-------------
        double average = (double)sum / numbers.Count;

//----------------Find largest number------------
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

//--------------Display results-------------
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}