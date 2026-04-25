using System;

class Program
{

    static void Main(string[] args)
        {
            DisplayWelcome();
            string name = PromptUserName();
            double userNumber = PromptUserNumber();
            int userBirthYear = PromptUserBirthYear();
            double numSquared = SquareNumber(userNumber);
            DisplayResult(name, numSquared, userBirthYear);
        }




    static void DisplayWelcome()
        {
        Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
        {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
        }

    static double PromptUserNumber()
        {
        Console.Write("Please enter your favorite number: ");
        double userNumber = double.Parse(Console.ReadLine());
        return userNumber;
        }

    static int PromptUserBirthYear()
        {
        Console.Write("Please enter the year you were born: ");
        int userBirthYear = int.Parse(Console.ReadLine());
        return userBirthYear;
        }

    static double SquareNumber(double number)
        {
            double numberSquared = (number * number);
            return numberSquared;
        }

    static void DisplayResult(string name, double numSquared, int birthYear)
        {
            int year = DateTime.Now.Year;
            int turnAge = (year - birthYear);

            Console.WriteLine($"{name}, the square of your number is {numSquared}.");
            Console.WriteLine($"{name}, you will turn {turnAge} this year.");

        }


}