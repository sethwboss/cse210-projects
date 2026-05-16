
public class Entry
{
    public Entry() {}



    public string _prompt;
    public string _response;
    public string _entryDate;


    public void DisplayEntry ()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }

}