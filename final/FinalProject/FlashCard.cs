public class FlashCard {
    
    public FlashCard(){}

    public FlashCard (string term, string definition)
    {
        _term = term;
        _definition = definition;
    }

    protected string _term = "";
    protected string _definition = "";


    public string GetDisplayString() {
        string _line =  $"{_term}: ({_definition})";
        return _line;
    }
    
    public string GetDefinition() {
        return _definition;
    }
    public string GetTerm() {
        return _term;
    }

}