/*
 * Eternal Quest Program
 * CSE 210 - Week 06
 *
 * Creativity and Exceeding Requirements:
 *
 * A Level System was added to increase user engagement.
 *
 * Level 1 = 0 points
 * Level 2 = 1000 points
 * Level 3 = 2500 points
 * Level 4 = 5000 points
 *
 * Users can track their progress through levels as
 * they earn points from completing goals.
 */

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
//