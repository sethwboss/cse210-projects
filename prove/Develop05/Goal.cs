public class Goal
{
    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    protected string _name = "";    
    protected string _description = "";
    protected int _pointValue = 0;

    public string GetSaveString(Goal goal)
    {
        string whole = "";
        foreach (line in goal)
        {
            string parts = line.Split()
            whole.Add(parts)
            whole.Add
        }
        
        return "";

    }

    
}