using System;

class Appointment : PlannerItem
{
    private string _time;
    private string _location;

    public Appointment(string title, string description, string date, string time, string location)
        : base(title, description, date)
    {
        _time = time;
        _location = location;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Location: " + _location);
    }

    public override string GetReminderMessage()
    {
        return "Appointment Reminder: Be at " +
               _location +
               " at " +
               _time +
               ".";
    }
}