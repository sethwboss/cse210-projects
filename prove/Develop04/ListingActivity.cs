public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    private  List<string> _prompts = new List<string>("When have you felt the Holy Ghost this month?");


    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            
        }
    }

    private string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string _prompt = _prompts[randomIndex];
        return _prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        string prompt = GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        LoadingTimer(5);
    }

}