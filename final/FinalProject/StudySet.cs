public class StudySet {
    
    public StudySet(){}


    
    private List<FlashCard> _studySet = new List<FlashCard>{};

    public void AddCard(FlashCard flashCard)
    {
        _studySet.Add(flashCard);
    }

    public List<FlashCard> GetStudySet() {
        return _studySet;
    }
}