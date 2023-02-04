public class Listing : Activity
{
    private List<string>_promptListing = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",

    };
    private List<string> _answers = new List<string>();
    private List<string> _randomPrompts = new List<string>();
    private string _descriptionListing;
    public Listing (string activity, int time, string descriptionListing) : base(activity, time)
    {
        _descriptionListing = descriptionListing;
    }

    public int PrintDescription()
    {
        string activity = GetActivity();
        Console.Write($"Welcome to the {activity} Activity.\n\r \n\r{_descriptionListing}\n\r \n\rHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        int userTime = int.Parse(userInput);
        return userTime;
        
    }
    public int GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptListing.Count);
        string promptListing = _promptListing[randomIndex];
        _randomPrompts.Add(promptListing);
        return randomIndex;
    }
    public void StartListing()
    {
        int time = GetTime();
        Console.WriteLine("Get Ready...");
        DisplayAnimation();
        Console.WriteLine();
        int index = GetRandomPrompt();
        string promptListing = _promptListing[index];
        Console.Write($"List as many responses you can to the following prompt:\n\r--- {promptListing} ---\n\rYou may begin in: ");
        DisplayTimer();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        int counter = 0;
        while(currentTime <= futureTime)
        {
            Console.Write(">");
            string answer = Console.ReadLine();
            // Guardar las respuesta en _answers para luego guardarlas en un documento.
            _answers.Add(answer);

            currentTime = DateTime.Now;
            counter += 1;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {counter} items!");
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        DisplayAnimation();
        Console.WriteLine();
        
    }


    public void ExtraOptions()
    {
        Console.Write("Do you want to save your answers:\n\ra. Yes\n\rb. No\n\r>");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "yes")
        {
            Console.WriteLine("What is the file name? ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                // get the memory and save it to the myFile.txt. Create 2 variables
                // to store the sentences and questions.
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                for (int i = 0; i <= _answers.Count() -1; i++)
                {
                    // obtener la pregunta aleatoria.
                    // hacer un loop por toda las respuestas e imprimirlas.
                    string getLastPrompt = _randomPrompts[0];
                    string answ = _answers[i];
                    outputFile.WriteLine($"Date: {dateText}\n\rPrompt: {getLastPrompt}\n\r{answ}\n\r \n\r");
                }
            }
            Console.Clear();
            Console.WriteLine("The answers have been already saved");
            DisplayAnimation();
            Console.Clear();
            
        }
        else if (userInput == "no")
        {
            Console.Clear();
        }


    }
}