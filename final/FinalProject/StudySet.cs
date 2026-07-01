public class StudySet {
    
    public StudySet(){}

    
    protected List<FlashCard> _studySet = new List<FlashCard>{};

    public void AddCard(FlashCard flashCard)
    {
        _studySet.Add(flashCard);
    }

    public string GetStudySetString() {
        
        FlashCard.getstudysetstring
    }

    //public abstract string GetSaveString();
    //public abstract int RecordEvent();
}