using System;

public class Menu
{
    private GoalManager _goalManager;

    public Menu(GoalManager goalManager)
    {
        _goalManager = goalManager;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            _goalManager.DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                _goalManager.CreateGoal();
            }
            else if (choice == 2)
            {
                _goalManager.ListGoalNames();
            }
            else if (choice == 3)
            {
                _goalManager.SaveGoals();
            }
            else if (choice == 4)
            {
                _goalManager.LoadGoals();
            }
            else if (choice == 5)
            {
                _goalManager.RecordEvent();
            }
        }
    }
}