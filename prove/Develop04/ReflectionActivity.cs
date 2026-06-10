public class ReflectionActivity : Activity
{
        public ReflectionActivity() : base("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {}

    private  List<string> _prompts = new List<string>("Think of a time when you did something really difficult.");
    private  List<string> _questions = new List<string>("How did you feel when it was complete?", "What is your favorite thing about this experience?");



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

    private string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string _prompt = _prompts[randomIndex];
        return _prompt;
    }
    private string GetQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string _questions = _questions[randomIndex];
        return _questions;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string prompt = GetPrompt();

        Console.WriteLine($" --- {prompt} ---");

        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        LoadingTimer(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetQuestion();
            Console.WriteLine($"> {question}");
            LoadingSpinner(5);

            // string answer = Console.ReadLine();
            // append answer to list of answer and save in separate file

            //could also make sure no duplicate question until we've gone through them all  - frmo the video

        }
    }

}