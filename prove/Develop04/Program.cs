using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool loop = true;
        while (loop == true) {

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
                breathingActivity.AskDuration();
                breathingActivity.RunActivity();
                breathingActivity.DisplayEnding();
            }
            if (userSelect == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayWelcome();
                reflectionActivity.AskDuration();
                reflectionActivity.RunActivity();
                reflectionActivity.DisplayEnding();
            }
            if (userSelect == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayWelcome();
                listingActivity.AskDuration();
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