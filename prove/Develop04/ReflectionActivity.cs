public class ReflectionActivity : Activity
{
        public ReflectionActivity() : base("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {}

    private  List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone who was struggling.",
        "Think of a challenge you overcame that made you stronger.",
        "Think of a time when you felt especially grateful.",
        "Think of a moment when you learned an important lesson.",
        "Think of a time when you stepped outside your comfort zone."
    };
    private  List<string> _questions = new List<string>
    {
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What did you learn from this experience?",
        "Who else was affected by this experience?",
        "What strengths did you discover in yourself?",
        "If you could relive this experience, would you do anything differently?",
        "How has this experience influenced your life since then?"
    };



    public void RunActivity()
    {
        DisplayPrompt();
        DisplayQuestions();
    }

    private string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        return prompt;
    }
    private string GetQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string _question = _questions[randomIndex];
        return _question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string currentPrompt = GetPrompt();

        Console.WriteLine($" --- {currentPrompt} ---");

        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        LoadingTimer(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetQuestion();
            Console.Write($"> {question} ");
            LoadingSpinner(10);

            

        }
    }

}