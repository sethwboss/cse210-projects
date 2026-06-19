public class GoalManager
{
    
    private List<Goal> _goalList = new List<Goal>();

    int _totalScore = 0;

    public void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_totalScore} points");
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int response = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int pointValue = int.Parse(Console.ReadLine());

        if (response == 1)
        {
            SimpleGoal simplegoal = new SimpleGoal(name, description, pointValue);
            _goalList.Add(simplegoal);
        }
        if (response == 2)
        {
            EternalGoal eternalgoal = new EternalGoal(name, description, pointValue);
            _goalList.Add(eternalgoal);

        }
        if (response == 3)
        {
            Console.Write("How many times does this goal need to be asccomplished for a bonus? ");
            int repeatAmount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusValue = int.Parse(Console.ReadLine());
            ChecklistGoal checklistgoal = new ChecklistGoal(name, description, pointValue, repeatAmount, bonusValue);
            _goalList.Add(checklistgoal);
        
        }
    }





    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        Console.WriteLine($"{_goalList}");
    }
    public void SaveGoals()
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            outputFile.WriteLine(_totalScore);
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetSaveString(goal));
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();



        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalScore = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");
            string name = parts[0];
            Console.Write($"{line} ");
            if (name == "SimpleGoal")
            {
                _goalList.Add(SimpleGoal.FromSaveString(line));
            }
            if (name == "EternalGoal")
            {
                _goalList.Add(EternalGoal.FromSaveString(line));
            }
            if (name == "ChecklistGoal")
            {
                _goalList.Add(ChecklistGoal.FromSaveString(line));
            }

    
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine($"You have {_totalScore} points");
    }

    public void HideGoals()
    {
        
    }
}