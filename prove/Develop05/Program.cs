using System;

// Creativity and Exceeding Requirements:
//
// Added a menu option that allows users to hide completed goals and
// display only goals that still need progress. This provides an easier
// way for users to focus on unfinished goals.
//
// Also enhanced the gamification aspect of the program by adding a
// larger celebration message when a checklist goal is completed and
// the bonus is earned, helping motivate users as they work toward
// their goals.

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;

        Program program = new Program();
        GoalManager goalmanage = new GoalManager();

        while (loop)
        {
            goalmanage.DisplayScore();
            loop = program.DisplayMenu(goalmanage);
        }
    }

    public bool DisplayMenu(GoalManager goalmanager)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. Hide Completed Goals");
        Console.WriteLine("   3. List Goals");
        Console.WriteLine("   4. Save Goals");
        Console.WriteLine("   5. Load Goals");
        Console.WriteLine("   6. Record Event");
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