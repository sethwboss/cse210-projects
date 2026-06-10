public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
        _duration = duration;
    }


    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            BreathIn();
            BreathOut();
        }
    }

    public void BreathIn()
    {
        Console.WriteLine();
        Console.Write("Breath In...4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
    }

    public void BreathOut()
    {
        Console.Write("Now breath out...6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
    }

    


}