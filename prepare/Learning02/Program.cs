using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2004;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Microsoft8";
        job2._jobTitle = "Software Engineer8";
        job2._startYear = 20048;
        job2._endYear = 20268;




        Resume resume1 = new Resume();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
  
        resume1.DisplayResume();

        
    }
}

