using System;

class PersonalTask : PlannerItem
{
    private string _personalCategory;

    public PersonalTask(string title, string description, string date, string personalCategory)
        : base(title, description, date)
    {
        _personalCategory = personalCategory;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Personal Category: " + _personalCategory);
    }

    public override string GetReminderMessage()
    {
        return "Personal Reminder: Remember your " +
               _personalCategory +
               " task.";
    }
}