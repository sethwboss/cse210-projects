public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int pointValue, bool isComplete) : base (name, description, pointValue)
    {
        _isComplete = isComplete;
    }

    private bool _isComplete;

    public override string GetSaveString()
    {
        return $"SimpleGoal|{_name}|{_description}|{_pointValue}|{(_isComplete ? 1 : 0)}";
    }
    public override string GetDisplayString() {
        string checkMark = _isComplete ? "[X]" : "[ ]"; 
        return $"{checkMark} {_name} ({_description})";
    }

    public static SimpleGoal FromSaveString(string line)
    {
        string[] parts = line.Split("|");
        string name = parts[1];
        string description = parts[2];
        int pointValue = int.Parse(parts[3]);
        bool isComplete = parts[4] == "1";

        {
            return new SimpleGoal(name, description, pointValue, isComplete);
        }
    }

    public override int RecordEvent()
    {
       if (!_isComplete)
        {
            Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");
            _isComplete = true;
            return _pointValue;
        }
       else {
        Console.WriteLine("You have already completed this task!");
        return 0;
       }
    }

    public override void HideCompleted() {
        if (_isComplete) {
            _hidden = true;
        }
    }
}