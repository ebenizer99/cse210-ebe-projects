using System;
using System.Collections.Generic;

class Planner
{
    private List<Category> _categories = new List<Category>();

    public void AddCategory(Category category)
    {
        _categories.Add(category);
    }

    public void AddItemToCategory(string categoryName, PlannerItem item)
    {
        foreach (Category category in _categories)
        {
            if (category.GetCategoryName() == categoryName)
            {
                category.AddItem(item);
                Console.WriteLine("Item added.");
                return;
            }
        }

        Console.WriteLine("Category not found.");
    }

    public void DisplayAllCategories()
    {
        foreach (Category category in _categories)
        {
            Console.WriteLine(category.GetCategoryName());
        }
    }

    public void DisplayAllItems()
    {
        foreach (Category category in _categories)
        {
            category.DisplayCategoryItems();
        }
    }

    public void MarkItemComplete(string title)
    {
        foreach (Category category in _categories)
        {
            if (category.MarkItemComplete(title))
            {
                Console.WriteLine("Item marked complete.");
                return;
            }
        }

        Console.WriteLine("Item not found.");
    }
}