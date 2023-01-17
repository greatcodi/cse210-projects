using System;

class Program
{
    static void Main(string[] args)
    {
        Terminal myTerminal = new Terminal();
        Book myBook = new Book();
        User myUser = new User();
        bool continuePlaying = myUser._GetContinue();
        myBook.ShowScripture();
        while(continuePlaying == true)
        {
            myTerminal.DisplayTextToTheRight("Press enter to continue or type 'quit' to finish\r\n-->>");
            string userInput = myTerminal.ReadString();
            if (userInput == "quit") 
            {
                myUser._SetContinue (false);
                continuePlaying = myUser._GetContinue();
            }
            else if (userInput == "")
            {
                
                myBook.ClearTerminal();
                myBook.ShowScripture();

                int listItems = myBook._scripture.Count();
                int counter = 0;
                for (int i=0; i < listItems; i++ )
                {
                    if (myBook._scripture[i] == "____")
                    {
                        counter += 1;
                    }

                }
                if (counter == listItems)
                {
                    myUser._SetContinue (false);
                    continuePlaying = myUser._GetContinue();
                }
            }
        }
    }
}