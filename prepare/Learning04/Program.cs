using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathassignment = new MathAssignment("Seth Boss", "Fractions", "7.3", "8-19");
        
        string summary = mathassignment.GetSummary();
        mathassignment.SetTextbookSection("7.8");
        mathassignment.SetProblems("7.4");

        string homeworklist = mathassignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworklist);
    }
}