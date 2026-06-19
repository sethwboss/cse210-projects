public class GoalManager
{
    
    private List<Goal> _goalList = new List<Goal>();

    private int _totalScore = 0;

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
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int repeatAmount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusValue = int.Parse(Console.ReadLine());
            ChecklistGoal checklistgoal = new ChecklistGoal(name, description, pointValue, bonusValue, repeatAmount);
            _goalList.Add(checklistgoal);
        
        }
    }



/* For the ListGoals count:
I intentionally kept the numbering aligned with the underlying goal list so that in the RecordEvent() method, 
selecting a goal by number would always reference the correct goal, even after completed goals were hidden.
This way of doing it also ensures that the user understands that some of the tasks are hidden, 
if it is only showing task 2 and task 4 as "2. Task name (description)", etc. and not 1 and 3.*/

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int count = 0;
        foreach (Goal goal in _goalList) {
            count ++;
            if (!goal.GetHiddenState())
            {
                Console.WriteLine($"{count}. {goal.GetDisplayString()}");
            }
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            outputFile.WriteLine(_totalScore);
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }
    public void LoadGoals()
    {
        _goalList.Clear();
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();



        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalScore = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");
            string name = parts[0];
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
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int response = int.Parse(Console.ReadLine());
        
        Goal goal = _goalList[response - 1];
        _totalScore += goal.RecordEvent();
        Console.WriteLine();
        Console.WriteLine($"You now have {_totalScore} points");
    }

    public void HideGoals()
    {
        foreach (Goal goal in _goalList) {
            goal.HideCompleted();
        }
    }
}