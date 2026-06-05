using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Seth Boss", "Fractions", "7.3", "8-19");
        
        string summary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);

        WritingAssignment writingAssignment = new WritingAssignment("Seth Boss", "European History", "The causes of World War II");

        string summary2 = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(summary2);
        Console.WriteLine(writingInfo);
    }
}