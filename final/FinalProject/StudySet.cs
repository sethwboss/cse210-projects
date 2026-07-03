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
        
        string totalLines = "";
        int count = 0;
        foreach (FlashCard flashCard in _studySet) {
            count ++;

            string line = $"{count}. {flashCard.GetDisplayString()}";

            totalLines += line;
            totalLines += "\n";

        }
        

        return totalLines;
    }

    public List<FlashCard> GetStudyList()
    {
        return _studySet;
    }

    //public abstract string GetSaveString();
    //public abstract int RecordEvent();
}