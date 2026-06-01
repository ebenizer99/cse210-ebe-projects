using System;

abstract class PlannerItem
{
private string _title;
private string _description;
private string _date;
private bool _isComplete;

```
public PlannerItem(string title, string description, string date)
{
    _title = title;
    _description = description;
    _date = date;
    _isComplete = false;
}

public string GetTitle()
{
    return _title;
}

public string GetDescription()
{
    return _description;
}

public string GetDate()
{
    return _date;
}

public bool IsComplete()
{
    return _isComplete;
}

public void MarkComplete()
{
    _isComplete = true;
}

public virtual void DisplayDetails()
{
    string status;

    if (_isComplete)
    {
        status = "Complete";
    }
    else
    {
        status = "Not Complete";
    }

    Console.WriteLine("Title: " + _title);
    Console.WriteLine("Description: " + _description);
    Console.WriteLine("Due Date: " + _date);
    Console.WriteLine("Status: " + status);
}

public virtual string GetReminderMessage()
{
    return "Reminder: " + _title + " is due on " + _date + ".";
}
```

}
