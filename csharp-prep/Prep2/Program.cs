using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is your Grade Percentage: ");
        string grade = Console.ReadLine();  
        int percent =  int.Parse(grade);
        string mark = "";

        if (percent >= 90)
        {
            mark = "A";
        }
        else if (percent >= 80)
        {
            mark = "B";
        }
        else if (percent >= 70)
        {
            mark = "C";
        }
        else if (percent >= 60)
        {
            mark = "D";
        }
        else
        {
            mark = "F";
        }

        Console.WriteLine($"Your grade is: {mark}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}