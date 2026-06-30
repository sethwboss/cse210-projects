public class FlashCard {
    
    public FlashCard(){}

    public FlashCard (string term, string definition)
    {
        _term = term;
        _definition = definition;
    }

    protected string _term = "";
    protected string _definition = "";



    public string GetDefinition(string definition) {
        return _definition;
    }
    public string GetTerm(string term) {
        return _term;
    }
}