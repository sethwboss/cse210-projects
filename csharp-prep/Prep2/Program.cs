using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();

        int gradeint = int.Parse(grade);

        string letter = "";
        if (gradeint >= 90)
        {
            letter = "A";
        }
        else if (gradeint >= 80)
        {
            letter = "B";
        }
        else if (gradeint >= 70)
        {
            letter = "C";
        }
        else if (gradeint >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade of {gradeint} gets you a letter grade of {letter}");

        if (gradeint > 69)
        {
            Console.WriteLine("Congratulations on passing the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, your grade did not pass the class. Better luck next time!");
        }
    }
}