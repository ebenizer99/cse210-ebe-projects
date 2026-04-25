using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Ask for Grade
        Console.WriteLine("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        //Determine letter Grade
        if (grade >= 90)
        {
            letter = "A";

        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";

        }
        //Determine sign 
        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >+ 7)
        {
            sign = "+";
        
        }
        else if (grade < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Special Cases 
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        //Print Letter Grade
        Console.WriteLine($"Your grade is {letter}{sign}");

        //Pass or Fail
        if (grade >= 70)
        {
            Console.WriteLine("Congratualtions! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying. You can do better next time.");
        }
    }
}