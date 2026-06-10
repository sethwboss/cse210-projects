public class ReflectionActivity : Activity
{
        public ReflectionActivity() : base("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {}

    private  List<string> _prompts = new List<string>("Think of a time when you did something really difficult.");
    private  List<string> questions = new List<string>("How did you feel when it was complete?", "What is your favorite thing about this experience?");



    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();
            DisplayQuestions();
        }
    }


    private void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();


        Console.WriteLine($" --- {} ---")

        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
    }

}