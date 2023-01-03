using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string getUserInput = Console.ReadLine();
            number = int.Parse(getUserInput);
            numbers.Add(number);
        }
        
        int total = 0;
        float average = 0;
        foreach (int i in numbers)
        {
            total += i;
            average = total / (numbers.Count - 1);
        }


        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}