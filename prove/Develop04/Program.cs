using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing myBreathing = new Breathing("Breathing", 10, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflection myReflection = new Reflection("Reflecting",10,"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing myListing = new Listing("Listing", 10, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int selectedOption = myBreathing.GetMenu();
        Console.Clear();
        bool keepPlaying = true;
        while (keepPlaying == true)
        {
            
            if (selectedOption == 1)
            {
                int getTime = myBreathing.PrintDescription();
                // set a new time given by the user to use it in the alternating messages function.
                
                myBreathing.SetTime(getTime);
                // Clear the console
                Console.Clear();
                myBreathing.AlternatingMessages();
                myBreathing.DisplayAnimation();
                Console.WriteLine("");
                myBreathing.FinalMessage();
                myBreathing.DisplayAnimation();
                Console.Clear();
                selectedOption = myBreathing.GetMenu();
                Console.Clear();
            }
            else if (selectedOption == 2)
            {
                int getTimeReflection = myReflection.PrintDescription();
                myReflection.SetTime(getTimeReflection);
                Console.Clear();
                myReflection.StartReflection();
                myReflection.FinalMessage();
                myReflection.DisplayAnimation();
                Console.Clear();
                selectedOption = myReflection.GetMenu();
                Console.Clear();        
            }
            else if (selectedOption == 3)
            {
                int getTimeListing = myListing.PrintDescription();
                myListing.SetTime(getTimeListing);
                Console.Clear();
                myListing.StartListing();
                myListing.FinalMessage();
                myListing.DisplayAnimation();
                Console.Clear();
                myListing.ExtraOptions();
                selectedOption = myReflection.GetMenu();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Thank you for getting this time! BBL!");
                keepPlaying = false;
            }
            
        }
        
    }
}