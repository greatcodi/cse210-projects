public class Terminal
// Print and get the input of the user
{
    
    public void Display(string text)
    {
        Console.WriteLine(text);
        
    }
    public void DisplayTextToTheRight (string text)
    {
        Console.Write(text);
    }
    public void DisplayNumber(int number)
    {
        Console.WriteLine(number);
        
    }
    
    
    public int ReadStringToNumber()
    {
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }
    public string ReadString()
    {
        string userInput = Console.ReadLine();
        return userInput;
    }

    public void DisplayScripture(string writingPassage, string scripture)
    {
        Console.WriteLine($"{writingPassage} {scripture}.");

    }
}