public class FlashCard {
    
    public FlashCard(){}

    public FlashCard (string term, string definition)
    {
        _term = term;
        _definition = definition;
    }

    protected string _term = "";
    protected string _definition = "";


    public List<FlashCard> GetStudySetString() {
        
        foreach (FlashCard studyset in _studySet)
        {
            string _line =  $"{_term} ({_definition})";
        }
    }
    
    public string GetDefinition() {
        return _definition;
    }
    public string GetTerm() {
        return _term;
    }

}