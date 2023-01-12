public class Terminal
// Print and get the input of the user
{
    
    public void Display(string text)
    {
        Console.WriteLine(text);
        
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

    public void DisplayJourney(string idea, string question)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date: {dateText} - Prompt: {question}\r\n{idea}");

    }
}