public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{_name}|{_description}|{_pointValue}";
    }
    public override string GetDisplayString() {
        return $"[ ] {_name} ({_description})";
    }
    public static EternalGoal FromSaveString(string line)
    {
        string[] parts = line.Split("|");
        string name = parts[1];
        string description = parts[2];
        int pointValue = int.Parse(parts[3]);

        {
            return new EternalGoal(name, description, pointValue);
        }
    }

    public override int RecordEvent()
    {
       Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");
       return _pointValue;
    }

    public override void HideCompleted() {
    }
}