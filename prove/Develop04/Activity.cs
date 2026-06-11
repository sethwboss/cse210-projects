using System.ComponentModel.DataAnnotations;

public class Activity
{
    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayWelcome ()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        AskDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingSpinner(3);
    }

    public void AskDuration ()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEnding ()
    {
        Console.WriteLine();
        Console.Write("Well done!!");
        Console.WriteLine();
        LoadingSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        LoadingSpinner(3);
        Console.Clear();
    }

    public void LoadingTimer (int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            seconds--;

            int length = seconds.ToString().Length;

            for (int j = 0; j < length; j++)
            {
                Console.Write("\b \b");
            }
        }
    }

    public void LoadingSpinner (int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

        Console.WriteLine();

    }





}