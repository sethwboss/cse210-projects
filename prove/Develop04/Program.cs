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
                breathingActivity.RunActivity();
                loop = false;
            }
            if (userSelect == "2")
            {
                loop = false;
            }
            if (userSelect == "3")
            {
                loop = false;
            }

            if (userSelect == "4")
            {
                loop = false;
            }
        }

    }
}