public class Word
{
    public Word(string text)
    {
        _characters = text;
    }

    private string _characters = "";
    private bool _isHidden = false;

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else {
            return true;
        }
    
    }

    public string GetText()
    {
        if (_isHidden)
        {
            string fullUnderline = "";
            for(int i = 0; i < _characters.Length; i++)
            {
                fullUnderline += "_";
            }
            return fullUnderline;
        }
        else
        {
            return _characters;
        }
    }
}