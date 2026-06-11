public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    
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
        Console.Write("Breathe In...");
        LoadingTimer(4);
    }

    public void BreathOut()
    {
        Console.WriteLine();
        Console.Write("Now breathe out...");
        LoadingTimer(6);
        Console.WriteLine();
    }

    


}