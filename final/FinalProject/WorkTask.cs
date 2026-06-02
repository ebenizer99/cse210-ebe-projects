using System;

class WorkTask : PlannerItem
{
    private string _workLocation;
    private string _priorityLevel;

    public WorkTask(string title, string description, string date,
                    string workLocation, string priorityLevel)
        : base(title, description, date)
    {
        _workLocation = workLocation;
        _priorityLevel = priorityLevel;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine("Work Location: " + _workLocation);
        Console.WriteLine("Priority Level: " + _priorityLevel);
    }

    public override string GetReminderMessage()
    {
        return "Work Reminder: This task is " +
               _priorityLevel +
               " priority at " +
               _workLocation +
               ".";
    }
}