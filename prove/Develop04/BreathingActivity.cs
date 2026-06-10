public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
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
        Console.Write("Breath In...");
        LoadingTimer(4);
    }

    public void BreathOut()
    {
        Console.Write("Now breath out...");
        LoadingTimer(6);
    }

    


}