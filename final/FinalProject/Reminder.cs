using System;

class Reminder
{
    private string _message;
    private string _date;

    public Reminder(string message, string date)
    {
        _message = message;
        _date = date;
    }

    public string GetMessage()
    {
        return _message;
    }

    public string GetDate()
    {
        return _date;
    }

    public void DisplayReminder()
    {
        Console.WriteLine("Reminder: " + _message);
        Console.WriteLine("Date: " + _date);
    }
}