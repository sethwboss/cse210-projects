using System.IO;
public class Journal
{
    public Journal() {}
    public void SaveToFile()
    {
        try
        {
            Console.WriteLine("What is the filename? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries) 
                {
                    outputFile.WriteLine($"{entry._prompt}|{entry._response}|{entry._entryDate}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You do not have permission to write to that location.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error: The directory path does not exist.");     
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: Could not save file. [ex.Message]");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: An unexpected error occurred. {ex.Message}");
        }
    }

    public void LoadFile()
    {
        try {
            _entries = new List<Entry>();
            
            Console.WriteLine("What is the filename? ");
            string filename = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                
                Entry loadedEntry = new Entry();

                loadedEntry._prompt = parts[0];
                loadedEntry._response = parts[1];
                loadedEntry._entryDate = parts[2];

                _entries.Add(loadedEntry);
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");     
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You do not have permission to read that file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: Could not load file. {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: An unexpected error occurred. {ex.Message}");
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