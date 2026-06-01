using System;
using System.Collections.Generic;

class Category
{
    private string _categoryName;
    private List<PlannerItem> _items = new List<PlannerItem>();

    public Category(string categoryName)
    {
        _categoryName = categoryName;
    }

    public void AddItem(PlannerItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(string title)
    {
        PlannerItem itemToRemove = null;

        foreach (PlannerItem item in _items)
        {
            if (item.GetTitle() == title)
            {
                itemToRemove = item;
            }
        }

        if (itemToRemove != null)
        {
            _items.Remove(itemToRemove);
        }
    }

    public void DisplayCategoryItems()
    {
        Console.WriteLine($"\n--- {_categoryName} ---");

        foreach (PlannerItem item in _items)
        {
            item.DisplayDetails();
            Console.WriteLine(item.GetReminderMessage());
        }
    }

    public string GetCategoryName()
    {
        return _categoryName;
    }

    public bool MarkItemComplete(string title)
    {
        foreach (PlannerItem item in _items)
        {
            if (item.GetTitle() == title)
            {
                item.MarkComplete();
                return true;
            }
        }

        return false;
    }
}