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
        Console.WriteLine();
    }

    public void AskDuration ()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        LoadingTimer(_duration);
    }

    public void DisplayEnding ()
    {
        Console.WriteLine();
        Console.Write("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another 30 seconds of the {_name}.");
        LoadingSpinner(3);
    }

    public void LoadingTimer (int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }

    public void LoadingSpinner (int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Thread.Sleep(250);
            Console.Write("|");
            Console.Write("\b \b");
            Thread.Sleep(250);
            Console.Write("/");
            Console.Write("\b \b");
            Thread.Sleep(250);
            Console.Write("-");
            Console.Write("\b \b");
            Thread.Sleep(250);
            Console.Write("\\");
            Console.Write("\b \b");
            Thread.Sleep(250);
        }

    }





}