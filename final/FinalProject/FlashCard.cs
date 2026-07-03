public class FlashCard {
    
    public FlashCard(){}

    public FlashCard (string term, string definition)
    {
        _term = term;
        _definition = definition;
    }

    private string _term = "";
    private string _definition = "";


    public string GetDisplayString() {
        string line =  $"{_term}: {_definition}";
        return line;
    }
    
    public string GetDefinition() {
        return _definition;
    }
    public string GetTerm() {
        return _term;
    }

}