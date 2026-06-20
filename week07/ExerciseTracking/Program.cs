using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all activities
        List<Activity> activities = new List<Activity>();

        // Add one activity of each type
        activities.Add(
            new Running(
                new DateTime(2022, 11, 3),
                30,
                4.8));

        activities.Add(
            new Cycling(
                new DateTime(2022, 11, 4),
                45,
                25.0));

        activities.Add(
            new Swimming(
                new DateTime(2022, 11, 5),
                40,
                30));

        // Display summaries for all activities
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}