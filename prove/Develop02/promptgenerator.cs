public class PromptGenerator
{
    public PromptGenerator() {}

    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most proud of today?",
        "How did I serve God or His children this day?",
        "What did I learn from the scriptures today?"
    };

    public void DisplayAllPrompts()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public string DisplayPrompt()
    {
        Random randomNum = new Random();
        int randomIndex = randomNum.Next(0, _prompts.Count);

        string chosenPrompt = _prompts[randomIndex];

        Console.WriteLine($"Your prompt: {chosenPrompt}");

        return chosenPrompt;

    }
}