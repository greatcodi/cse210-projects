public class WriteJourney
// Prompt the words to the user so that, the user can know what to write.
{
    public List<string> prompts = new List<string>()
    {
        "What was the most interesting thing in your day?",
        "What was the funniest thing in your day?",
        "What did you learn today",
        "Are you happy today? Why?",
        "Is there something that you could do better? What is it?",
        "Did you show love today? Why or why not?",
        "Did you smile today? What happened?",
        "What do you think now?"        
    };

    public string GetPrompt()
    {
        Random randomString = new Random();
        int index = randomString.Next(prompts.Count());
        string randomPrompt = prompts[index];
        return randomPrompt;
    
    }
    
}