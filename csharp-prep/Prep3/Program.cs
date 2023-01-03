using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magic = int.Parse(userInput);
        // Console.WriteLine(magic);
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);

        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            


            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            int  number = int.Parse(userInput2);
            

            if (number == magic)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine("Do you want to keep playing (yes/no): ");
                keepPlaying = Console.ReadLine();
                magic = randomGenerator.Next(1,100);
                if (keepPlaying != "yes")
                {
                    Console.WriteLine("Thank you for playing. Game Over!");
                }
            }
            else if (number < magic)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }
            
        }
        
        
    }
}