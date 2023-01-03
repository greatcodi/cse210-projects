using System;

class Program
{
    
    static void Main(string[] args)
    {
        string letter;
        
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
    

        if (percentage >= 90)
        {   
            letter = "A";
            
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
            
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");




        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations!! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not passed the course. You can do it better next time. Just hang in there!");
        }
        
    }

    
}