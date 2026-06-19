public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
        _isComplete = false;
    }

    private bool _isComplete;

    public static SimpleGoal GetSaveString(string line)
    {
        return $"SimpleGoal|{_name}|{_description}|{_pointValue}|{(_isComplete ? 1 : 0)}";
    }

    public static SimpleGoal FromSaveString(string line)
    {
        {
            string[] parts = line.Split("|");
            string name = parts[0];
            string description = parts[1];
            int pointValue = int.Parse(parts[2]);
            bool isComplete = parts[3] == "1";
            if (isComplete == "0")
            {
                return $" [] {name} ({description})";
            }
            if (isComplete == "1")
            {
                return $" [X] {name} ({description})";  
            }
        }
    }

    public string FromSaveString(string fullstring)
    
}