public class Reflection : Activity
{
    private string _descriptionReflection;
    private List<string>_prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string>_questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection (string activity, int time, string descriptionReflection) : base(activity, time)
    {
        _descriptionReflection = descriptionReflection;
    }


    public int PrintDescription()
    {
        string activity = GetActivity();
        Console.Write($"Welcome to the {activity} Activity.\n\r \n\r{_descriptionReflection}\n\r \n\rHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        int userTime = int.Parse(userInput);
        return userTime;
        
    }

    public void StartReflection()
    {
        Console.WriteLine("Get Ready...");
        DisplayAnimation();
        

        Random random = new Random();
        int indexPrompt = random.Next(_prompts.Count);
        string prompt = _prompts[indexPrompt];
        Console.WriteLine($"Consider the following prompt:\n\r--- {prompt} ---\n\r \n\rWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Now ponder of each of the following questions as they related to this experience.\n\rYou may begin in: ");
        int time = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(3);
        DateTime currentTime = DateTime.Now;
        while (currentTime <= futureTime)
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            currentTime = DateTime.Now;
             Console.WriteLine();
            
        }

        Console.Clear();
        
        
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(time);
        currentTime = DateTime.Now;
        while(currentTime <= futureTime)
        {
            int indexQuestion = random.Next(_questions.Count);
            string question = _questions[indexQuestion];
            Console.Write($"{question} ");
            DisplayAnimation();
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        Console.WriteLine("");
        Console.Write("Well done!!");
        DisplayAnimation();
        Console.WriteLine();
        Console.WriteLine();

        
    }
}