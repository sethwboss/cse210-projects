using System;

/* 
Exceeding requirements and showing creativity:

NOTE: I had trouble running this program in VS Code (The menu would occasionally print twice and the "Get ready..." text wouldn't clear. This was not because of faulty code but some other error). I did extensive research with AI, and could not figure out what was causing these errors.
However, when I ran the project through a Powershell terminal, all of these errors went away. Here is the command I used to run it if you encounter the same issue: 
cd 'C:\Users\sethw\Documents\BYU-Idaho Classes\Spring_2026\CSE 210\cse210-projects\prove\Develop04'
dotnet run
*/

class Program
{
    static void Main(string[] args)
    {
        
        bool loop = true;
        while (loop) {

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            string userSelect = Console.ReadLine();
            if (userSelect == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayWelcome();
                breathingActivity.RunActivity();
                breathingActivity.DisplayEnding();
            }
            if (userSelect == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayWelcome();
                reflectionActivity.RunActivity();
                reflectionActivity.DisplayEnding();
            }
            if (userSelect == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayWelcome();
                listingActivity.RunActivity();
                listingActivity.DisplayEnding();
            }

            if (userSelect == "4")
            {
                loop = false;
            }
        }

    }
}