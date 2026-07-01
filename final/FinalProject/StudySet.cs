public class StudySet {
    
    public StudySet(string name){
        _name = name;
    }

    private string _name = "";
    
    private List<FlashCard> _studySet = new List<FlashCard>{};

    public void AddCard(FlashCard flashCard)
    {
        _studySet.Add(flashCard);
    }

    public string GetStudySetName()
    {
        return _name;
    }

    public string GetStudySetString() {
        
        Console.WriteLine($"{_name}");
        
        string _totalLines = "";
        int count = 0;
        foreach (FlashCard flashCard in _studySet) {
            count ++;

            string _line = $"{count}. {flashCard.GetDisplayString()}";

            _totalLines += _line;
            _totalLines += "\n";

        }
        

        return _totalLines;
    }

    //public abstract string GetSaveString();
    //public abstract int RecordEvent();
}