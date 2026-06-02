using System;

class Program
{
    static void Main(string[] args)
    {
        Planner planner = new Planner();

        Category school = new Category("School");
        Category work = new Category("Work");
        Category personal = new Category("Personal");

        planner.AddCategory(school);
        planner.AddCategory(work);
        planner.AddCategory(personal);

        string choice = "";

        while (choice != "8")
        {
            Console.WriteLine();
            Console.WriteLine("Planner Menu");
            Console.WriteLine("1. Add School Task");
            Console.WriteLine("2. Add Work Task");
            Console.WriteLine("3. Add Personal Task");
            Console.WriteLine("4. Add Appointment");
            Console.WriteLine("5. View All Items");
            Console.WriteLine("6. Mark Item Complete");
            Console.WriteLine("7. Show Reminder");
            Console.WriteLine("8. Quit");
            Console.Write("Select an option: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Date: ");
                string date = Console.ReadLine();

                Console.Write("Course Name: ");
                string course = Console.ReadLine();

                Console.Write("Assignment Type: ");
                string assignment = Console.ReadLine();

                SchoolTask task = new SchoolTask(title, description, date, course, assignment);
                planner.AddItemToCategory("School", task);
            }
            else if (choice == "2")
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Date: ");
                string date = Console.ReadLine();

                Console.Write("Work Location: ");
                string location = Console.ReadLine();

                Console.Write("Priority Level: ");
                string priority = Console.ReadLine();

                WorkTask task = new WorkTask(title, description, date, location, priority);
                planner.AddItemToCategory("Work", task);
            }
            else if (choice == "3")
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Date: ");
                string date = Console.ReadLine();

                Console.Write("Personal Category: ");
                string category = Console.ReadLine();

                PersonalTask task = new PersonalTask(title, description, date, category);
                planner.AddItemToCategory("Personal", task);
            }
            else if (choice == "4")
            {
                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Date: ");
                string date = Console.ReadLine();

                Console.Write("Time: ");
                string time = Console.ReadLine();

                Console.Write("Location: ");
                string location = Console.ReadLine();

                Appointment appointment = new Appointment(title, description, date, time, location);
                planner.AddItemToCategory("Personal", appointment);
            }
            else if (choice == "5")
            {
                planner.DisplayAllItems();
            }
            else if (choice == "6")
            {
                Console.Write("Enter title to mark complete: ");
                string title = Console.ReadLine();

                planner.MarkItemComplete(title);
            }
            else if (choice == "7")
            {
                Reminder reminder = new Reminder("Check your planner every day", "Daily");
                reminder.DisplayReminder();
            }
            else if (choice == "8")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}