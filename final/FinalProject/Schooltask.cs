using System;

class SchoolTask : PlannerItem
{
    private string _courseName;
    private string _assignmentType;

    public SchoolTask(string title, string description, string date, string courseName, string assignmentType)
        : base(title, description, date)
    {
        _courseName = courseName;
        _assignmentType = assignmentType;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Course: {_courseName}");
        Console.WriteLine($"Assignment Type: {_assignmentType}");
    }

    public override string GetReminderMessage()
    {
        return $"School Reminder: Complete your {_assignmentType} for {_courseName}.";
    }
}