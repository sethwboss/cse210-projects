using System.IO;
public class Journal
{
    
    public Journal() {}
    
    public void SaveToFile()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries) 
            {
                outputFile.WriteLine($"{entry._prompt},{entry._response},{entry._entryDate}");
            }
        }
        
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            Entry loadedEntry = new Entry();

            loadedEntry._prompt = parts[0];
            loadedEntry._response = parts[1];
            loadedEntry._entryDate = parts[2];

            _entries.Add(loadedEntry);


        }
    }



    public List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }



}