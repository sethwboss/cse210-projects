public class Scripture
{
    public Scripture() {}
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = SplitString(text);
    }
    private Reference _reference;
    private List<Word> _words = new List<Word>{};



    private List<Word> SplitString(string text)
    {
        List<Word> localWords = new List<Word>{};
        string[] splitList = text.Split(' ');
        foreach(string word in splitList)
        {
            Word singleWord = new Word(word);
            localWords.Add(singleWord);
        }
        return localWords;
    }

    public bool AllWordsHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden() == true)
            {
                return false;
            }
        }
        return true;
    }
    public void HideWords()
    {
        Random random = new Random();
        int hiddenCount = 0;
        while(hiddenCount < 3 && !AllWordsHidden())
        {
            int randomIndex = random.Next(_words.Count);
            
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetText()
    {
        string text = "";
        text += _reference.GetText();
        text += " ";

        foreach(Word word in _words)
        {
            text += word.GetText() + " ";
        }
        return text;
    }
}