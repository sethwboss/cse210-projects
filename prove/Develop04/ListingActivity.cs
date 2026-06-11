
public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    private  List<string> _prompts = new List<string>{
        "When have you felt the Holy Ghost this month?",
        "How have you seen the Lord's hand in your life recently?",
        "Where have you found joy in the past month?",
        "What do you want to work on about yourself?",
        "What are your strengths and accomplishments you're proud of?"
    };

    private  List<string> _answers = new List<string>();

    private string _currentPrompt = "";
    private int _count;


    public void RunActivity()
    {
        DisplayPrompt();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _count = 0;

        while (DateTime.Now < endTime)
        {
            GetAnswer();
        }
        CountUserInput();

        bool loop = true;
        while (loop)
        {
            loop = SaveResponses();
        }
        
    }

    private string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        return prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");

        _currentPrompt = GetPrompt();
        Console.WriteLine($" --- {_currentPrompt} ---");
        Console.Write("You may begin in: ");
        LoadingTimer(5);
        Console.WriteLine();
    }

    public void GetAnswer()
    {
        Console.Write("> ");
        string answer = Console.ReadLine();
        _answers.Add(answer);
        _count++;
    }

    public void CountUserInput()
    {
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }

    public bool SaveResponses()
    {
    

        try
        {
            Console.WriteLine("Name a file to save your responses to (new or existing): ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                outputFile.WriteLine(_currentPrompt);

                foreach (string indivAnswer in _answers) 
                {
                    outputFile.WriteLine(indivAnswer);
                }
                outputFile.WriteLine();
            }
            Console.WriteLine("Journal saved successfully!");
            return false;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You do not have permission to write to that location.");
            return true;
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error: The directory path does not exist.");  
            return true;   
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: Could not save file. [ex.Message]");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: An unexpected error occurred. {ex.Message}");
            return true;
        }
    }

    



}