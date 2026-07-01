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
        }
    }

    public bool DisplayMenu(MenuManager menuManager)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Study Set");
        Console.WriteLine("   2. View Study Set");
        Console.WriteLine("   3. Delete Study Set");
        Console.WriteLine("   4. Quiz Names");
        Console.WriteLine("   5. Quiz Terms");
        Console.WriteLine("   6. Multiple Choice Quiz");
        Console.WriteLine("   7. See Scores");
        Console.WriteLine("   8. Quit");
        Console.Write("Select a choice from the menu: ");

        int response = int.Parse(Console.ReadLine());

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
            menuManager.QuizNames();
            return true;
        }
        if (response == 5) {
            menuManager.QuizTerms();
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