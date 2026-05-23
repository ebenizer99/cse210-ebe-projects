using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Current Level: {GetLevel()}");
    }

    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetAmount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonusPoints));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
            Console.WriteLine($"Current Level: {GetLevel()}");
        }
    }

    public void SaveGoals()
    {
        FileManager.SaveGoals(_goals, _score);
    }

    public void LoadGoals()
    {
        FileManager.LoadGoals(out _goals, out _score);
    }
}