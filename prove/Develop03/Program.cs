using System;

/*
    Exceeding requirements: Added a 4th Class, ScriptureLibrary,
    to hold 3 different scripture passages that are randomly selected
    and then called a function to create a random number and choose
    one of the 3 scriptures to memorize during the main loop of the program.
*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer program!");
        Console.WriteLine("Press Enter to hide words, enter 'quit' to exit the program. Press Enter to begin.");
        string userStart = Console.ReadLine();
        
        ScriptureLibrary scriptures = new ScriptureLibrary();
        Scripture scripture = scriptures.GetScripture();
        
        bool loop = true;
        if (userStart == "quit")
            {
                loop = false;
            }
        while (loop == true) {
            if (scripture.AllWordsHidden())
            {
                loop = false;
            }

            Console.Clear();
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit the program:");
            string userSelect = Console.ReadLine();
            scripture.HideWords();

            if (userSelect == "quit")
            {
                loop = false;
            }
        }
    }
}