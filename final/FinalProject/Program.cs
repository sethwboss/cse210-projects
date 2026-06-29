using System;

/* Creativity and Exceeding Requirements:

*/

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;

        //Program program = new Program();
        //GoalManager goalmanage = new GoalManager();

        while (loop)
        {
            goalmanage.DisplayScore();
            loop = program.DisplayMenu(goalmanage);
        }
    }

    public bool DisplayMenu(GoalManager goalmanager)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Study Set");
        Console.WriteLine("   2. Delete Study Set");
        Console.WriteLine("   3. Quiz Names");
        Console.WriteLine("   4. Quiz Terms");
        Console.WriteLine("   5. Multiple Choice Quiz");
        Console.WriteLine("   6. See Scores");
        Console.WriteLine("   7. Quit");
        Console.Write("Select a choice from the menu: ");

        int response = int.Parse(Console.ReadLine());

        if (response == 1) {
            goalmanager.CreateGoal();
            return true;
        }
        if (response == 2) {
            goalmanager.HideGoals();
            return true;
        }
        if (response == 3) {
            goalmanager.ListGoals();
            return true;
        }
        if (response == 4) {
            goalmanager.SaveGoals();
            return true;
        }
        if (response == 5) {
            goalmanager.LoadGoals();
            return true;
        }
        if (response == 6) {
            goalmanager.RecordEvent();
            return true;
        }
        if (response == 7) {
            return false;
        }
        else {
            Console.WriteLine("Invalid input. Try again.");
            return true;
        }
    }
}