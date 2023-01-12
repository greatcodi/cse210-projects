using System;
using System.IO;

class Program
{
    
    
    static void Main()
    {
        Journey myJourney = new Journey();
        Terminal myTerminal = new Terminal();
        WriteJourney myWriteJourney = new WriteJourney();
        Memory myMemory = new Memory();

        int optionNumber = 1;
        while (optionNumber != 5)
        {
            

            string text = "Please select one of the following choices\r\n1. Write\r\n2. Display\r\n3. Load\r\n4. Save\r\n5. Quit\r\nWhat would you like to do? ";
            myTerminal.Display(text);
            optionNumber = myTerminal.ReadStringToNumber();
            myJourney.SetOptionNumber(optionNumber);
            optionNumber = myJourney.optionNumber;
            Console.WriteLine("");

            if (optionNumber == 1 )
            {
                string randomPrompt = myWriteJourney.GetPrompt();
                myTerminal.Display(randomPrompt);
                
                string ideas = myTerminal.ReadString();
                // create a new class to save all the ideas and the prompt in a list
                myMemory.AddToSentences(ideas);
                myMemory.AddToQuestions(randomPrompt);

            }
            else if (optionNumber == 2)
            {
                myMemory.PrintLoading();
                myMemory.PrintAddQuestionIdea();

            }

            else if (optionNumber == 3)
            {
                string text4 = "What is the file name? ";
                myTerminal.Display(text4);
                string fileName = myTerminal.ReadString();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~");

                    string sentence = parts[0];
                    Console.WriteLine(sentence);
                    myMemory.loadings.Add(sentence);
                }
                Console.WriteLine("----------------------");
                Console.WriteLine("The file has already loaded");
                Console.WriteLine("----------------------");
            }

            else if (optionNumber == 4)
            {
                string text3 = "What is the file name? ";
                myTerminal.Display(text3);
                string fileName = myTerminal.ReadString();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    // get the memory and save it to the myFile.txt. Create 2 variables
                    // to store the sentences and questions.
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    for (int i = 0; i <= myMemory.sentences.Count() -1; i++)
                    {
                        string question = myMemory.questions[i];
                        string sentence = myMemory.sentences[i];
                        outputFile.WriteLine($"Date: {dateText} - Prompt: {question}\r\n{sentence}");
                    }
                }
                string text4 = "The journey has been already saved";
                myTerminal.Display(text4);
            }
        }
        
        string text2 = "Thank you for using the Journey, BFN!";
        myTerminal.Display(text2);
        
    }    
}
