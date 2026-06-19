public abstract class Goal
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

    protected bool _hidden = false;

    
    public abstract string GetDisplayString();
    public abstract string GetSaveString();
    public abstract int RecordEvent();

    public abstract void HideCompleted();

    public bool GetHiddenState() {
        return _hidden;
    }
    
}