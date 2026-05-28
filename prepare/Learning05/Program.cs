using System;

class Program
{
    static void Main(string[] args)
    {
        Planner planner = new Planner();

        planner.AddCategory(new Category("School"));
        planner.AddCategory(new Category("Work"));
        planner.AddCategory(new Category("Personal"));
        planner.AddCategory(new Category("Appointments"));

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nDaily Planner App");
            Console.WriteLine("1. Add School Task");
            Console.WriteLine("2. Add Work Task");
            Console.WriteLine("3. Add Personal Task");
            Console.WriteLine("4. Add Appointment");
            Console.WriteLine("5. Display All Items");
            Console.WriteLine("6. Display All Categories");
            Console.WriteLine("7. Mark Item Complete");
            Console.WriteLine("8. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                SchoolTask task = new SchoolTask("Physics Homework", "Finish optics problems", "Friday", "PH123", "Homework");
                planner.AddItemToCategory("School", task);
            }
            else if (choice == "2")
            {
                WorkTask task = new WorkTask("Work Shift", "Complete assigned duties", "Saturday", "Office", "High");
                planner.AddItemToCategory("Work", task);
            }
            else if (choice == "3")
            {
                PersonalTask task = new PersonalTask("Gym", "Workout for one hour", "Today", "Health");
                planner.AddItemToCategory("Personal", task);
            }
            else if (choice == "4")
            {
                Appointment appointment = new Appointment("Meeting", "Meet with project group", "Monday", "3:00 PM", "Library");
                planner.AddItemToCategory("Appointments", appointment);
            }
            else if (choice == "5")
            {
                planner.DisplayAllItems();
            }
            else if (choice == "6")
            {
                planner.DisplayAllCategories();
            }
            else if (choice == "7")
            {
                Console.Write("Enter the title of the item to mark complete: ");
                string title = Console.ReadLine();
                planner.MarkItemComplete(title);
            }
            else if (choice == "8")
            {
                running = false;
            }
        }
    }
}


