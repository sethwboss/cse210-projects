using System;

/*

Exceeding the requirements and showing creativity:
-Added an error message in the else statement during the loop to prompt the user to select options 0-5.
-Added an option "0" for the user to create a new prompt, and configured the if statement to add the new prompt to the original list in the promptgenerator class.
-Improved file handling with  try/catch blocks in the journal class for invalid file names and in program.cs for int.parse

*/

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptList = new PromptGenerator();
        Journal journal = new Journal();

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
            string input = (Console.ReadLine());
            if (!int.TryParse(input, out int response))
            {
                Console.WriteLine("Invalid Input. Please enter options 0-5.");
                continue;
            }


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

            else if (response == 1)
            {
                Entry entry = new Entry();
                string chosenPrompt = promptList.DisplayPrompt();
                entry._prompt = chosenPrompt;

                Console.Write("> ");
                string userResponse = Console.ReadLine();
                entry._response = userResponse;

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
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
        }
    }
}