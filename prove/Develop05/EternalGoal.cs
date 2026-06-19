public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
        
    }

    public static EternalGoal GetSaveString(string line)
    {
        return $"EternalGoal|{_name}|{_description}|{_pointValue}";
    }
    public static SimpleGoal FromSaveString(string line)
    {
        
    }
}