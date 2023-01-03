using System;

class Program
{
    static void Main(string[] args)
    {
        string greeting = "Welcome to the program!";
        DisplayWelcome(greeting);
        string prompt = "Please enter your name: ";
        string name = PromptUserName(prompt);
        string promptForNumber = "Please enter your favorite number: ";
        int userNumber = PromptUserNumber(promptForNumber);
        int total = SquareNumber(userNumber);
        DisplayResult(name,total);

    }

    static void DisplayWelcome(string greeting)
    {
        Console.WriteLine(greeting);
    }


    static string PromptUserName(string prompt)
    {
        Console.Write(prompt);
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(string prompt)
    {
        Console.Write(prompt);
        string getUserNumber = Console.ReadLine();
        int number = int.Parse(getUserNumber);
        return number;

    }
    static int SquareNumber(int number)
    {
        int total = number * number;
        return total;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {number}");
    }
}