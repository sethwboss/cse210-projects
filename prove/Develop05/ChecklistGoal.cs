public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int pointValue, int repeatAmount, int bonusValue) : base (name, description, pointValue)
    {
        _repeatAmount = repeatAmount;
        _bonusValue = bonusValue;
    }

    int _repeatAmount = 0;
    int _bonusValue = 0;


    
    public static SimpleGoal FromSaveString(string line)
    {
        
    }

{name} ({description}) -- Currently completed: {repeatAmount} {bonusValue}

}