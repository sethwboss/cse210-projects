
public class Reference
{
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }


    private string _book = "";
    private int _chapter = 0;
    private int _startVerse = 0;
    private int _endVerse = 0;

    public string GetText()
    {

        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";

        }
    }
}