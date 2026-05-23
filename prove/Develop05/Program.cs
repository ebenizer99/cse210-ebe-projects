using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: I exceeded the core requirements by adding a leveling system.
        // The user earns a new level every 1000 points, which adds a gamification
        // feature beyond the required score tracking.

        GoalManager manager = new GoalManager();
        Menu menu = new Menu(manager);

        menu.Start();
    }
}