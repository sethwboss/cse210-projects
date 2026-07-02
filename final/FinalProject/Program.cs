using System;

/* Creativity and Exceeding Requirements:

*/

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;

        Program program = new Program();
        MenuManager menuManager = new MenuManager();
        Console.Clear();

        while (loop)
        {
            loop = program.DisplayMenu(menuManager);
            Console.WriteLine();
        }
    }

    public bool DisplayMenu(MenuManager menuManager)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Study Set");
        Console.WriteLine("   2. View Study Set");
        Console.WriteLine("   3. Delete Study Set");
        Console.WriteLine("   4. Term Quiz");
        Console.WriteLine("   5. Definition Quiz");
        Console.WriteLine("   6. Multiple Choice Quiz");
        Console.WriteLine("   7. See Points");
        Console.WriteLine("   8. Quit");
        Console.Write("Select a choice from the menu: ");

        string responseString = (Console.ReadLine());
        int response = 0;
        try {
            response = int.Parse(responseString);
        }
        catch {}

        if (response == 1) {
            menuManager.CreateStudySet();
            return true;
        }
        if (response == 2) {
            menuManager.SeeStudySet();
            return true;
        }
        if (response == 3) {
            menuManager.DelStudySet();
            return true;
        }
        if (response == 4) {
            menuManager.TermQuiz();
            return true;
        }
        if (response == 5) {
            menuManager.DefinitionQuiz();
            return true;
        }
        if (response == 6) {
            menuManager.MultipleChoiceQuiz();
            return true;
        }
        if (response == 7) {
            menuManager.SeeScores();
            return true;
        }
        if (response == 8) {
            return false;
        }
        else {
            Console.WriteLine("Invalid input. Try again.");
            return true;
        }
    }
}