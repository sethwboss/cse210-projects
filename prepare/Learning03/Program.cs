using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Fraction Program!");

        Random random = new Random();
          for (int i = 1; i < 21; i++)
        {
        
        int top = random.Next(1, 10);
        int bottom = random.Next(1, 10);

        Fraction fraction = new Fraction();

        fraction.SetTop(top);
        fraction.SetBottom(bottom);

        string stringValue = fraction.GetFractionString();
        double decimalValue = fraction.GetDecimalValue();

        

        Console.WriteLine($"Fraction {i}: string: {stringValue} Number: {decimalValue}");

        }



        

        
    }
}