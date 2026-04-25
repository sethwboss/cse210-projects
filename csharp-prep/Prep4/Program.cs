using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();

        int currentnum = 1;
        int testnum = 0;
        Boolean loop = true;
        while (loop == true)
        {
            Console.WriteLine("Enter number: ");
            currentnum = int.Parse(Console.ReadLine());

    

            if (currentnum == 0)
            {
                loop = false;
            }
            else
            {
                numbers.Add(currentnum);
                testnum = currentnum;
            }

        }

        int sum = 0;
        int largestnum = testnum;
        int count = 0;
        foreach (int number in numbers)
        {
            count ++;
            currentnum = number;
            sum += currentnum;
            
            if (currentnum > largestnum)
            {
                largestnum = currentnum;
            }
            else {}
        }

        double average = ((double)sum / count);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestnum}");



    }
}