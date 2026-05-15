using System;
using System.Net;

class Program
{
    static void Main(string[] args)

    
    {

        PromptGenerator promptList = new PromptGenerator();
        Journal journal = new Journal();


        DateTime CurrentTime = DateTime.Now;

        Console.WriteLine("Welcome to the Journal Program!");
        bool loop = true;
        while (loop == true)
        {
        Console.WriteLine("Please select one of the following choices (type the number): ");
        Console.WriteLine("0. Create Prompt");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        int response = int.Parse(Console.ReadLine());

        

        if (response == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Here is the current list of journal prompts:");
            promptList.DisplayAllPrompts();
            Console.WriteLine("");
            Console.WriteLine("Type the prompt you would like to add: ");
            string newPrompt = Console.ReadLine();
            promptList._prompts.Add(newPrompt);
        }

        if (response == 1)
        {
            Entry entry = new Entry();
            string chosenPrompt = promptList.DisplayPrompt();
            entry._prompt = chosenPrompt;

            Console.Write("> ");
            string userResponse = Console.ReadLine();
            entry._response = userResponse;

            string dateText = CurrentTime.ToShortDateString();
            entry._entryDate = dateText;

            journal.AddEntry(entry);
        }
        else if (response == 2) 
        {
            journal.DisplayAllEntries();
        }
        else if (response == 3) 
        {
            journal.LoadFile();
            
        }
        else if (response == 4) 
        {
            journal.SaveToFile();
        }
        else if (response == 5)
        {
            loop = false;
        }
        else
            {
                Console.WriteLine("Invalid Input. Please enter options 0-5.");
            }
        }
        
    }
}