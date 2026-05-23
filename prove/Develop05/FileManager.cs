using System;
using System.Collections.Generic;
using System.IO;

public class FileManager
{
    public static void SaveGoals(List<Goal> goals, int score)
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(score);

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public static void LoadGoals(out List<Goal> goals, out int score)
    {
        goals = new List<Goal>();

        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                int targetAmount = int.Parse(parts[4]);
                int bonusPoints = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonusPoints, amountCompleted));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}