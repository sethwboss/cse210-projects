public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int repeatAmount) : base (name, description, pointValue)
    {
        _repeatAmount = repeatAmount;
        _bonusValue = bonusValue;
        _completedAmount = 0;
    }
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int repeatAmount, int completedAmount) : base (name, description, pointValue)
    {
        _repeatAmount = repeatAmount;
        _bonusValue = bonusValue;
        _completedAmount = completedAmount;
    }

    private int _repeatAmount = 0;
    private int _completedAmount = 0;
    private int _bonusValue = 0;


    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_pointValue}|{_bonusValue}|{_repeatAmount}|{_completedAmount}";
    }
    public override string GetDisplayString() {
        string checkMark = _completedAmount == _repeatAmount ? "[X]" : "[ ]"; 
        return $"{checkMark} {_name} ({_description}) -- Currently completed: {_completedAmount}/{_repeatAmount}";
    }
    public static ChecklistGoal FromSaveString(string line)
    {
        string[] parts = line.Split("|");
        string name = parts[1];
        string description = parts[2];
        int pointValue = int.Parse(parts[3]);
        int bonusValue = int.Parse(parts[4]);
        int repeatAmount = int.Parse(parts[5]);
        int completedAmount = int.Parse(parts[6]);

        {
            return new ChecklistGoal(name, description, pointValue, bonusValue, repeatAmount, completedAmount);
        }
    }
    
    public override int RecordEvent()
    {
       _completedAmount ++;
       if (_completedAmount < _repeatAmount) {
        Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");
        return _pointValue;
       }
       else if (_completedAmount == _repeatAmount) {
        Console.WriteLine($"*** CONGRATULATIONS! You earned {_pointValue} AND a bonus {_bonusValue} for completing this task!! ***");
        return _pointValue + _bonusValue;
       }
       else {
        _completedAmount --;
        Console.WriteLine("You have already completed this task!");
        return 0;
       }
    }

    public override void HideCompleted() {
        if (_completedAmount == _repeatAmount) {
            _hidden = true;
        }
    }
}