public class Breathing : Activity
{
    private string _description;
    public Breathing (string activity, int time, string description) : base(activity, time)
    {
        _description = description;
    }






    public int PrintDescription()
    {
        string activity =GetActivity();
        Console.Write($"Welcome to the {activity} Activity.\n\r \n\r{_description}\n\rHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        int userTime = int.Parse(userInput);
        return userTime;
    }
    public void AlternatingMessages()
    {
        Console.WriteLine("Get ready...");   
        DisplayAnimation();
        Console.WriteLine("");
        Console.WriteLine("");


        int time = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        while (currentTime <= futureTime)
        {
            Random random = new Random();
            int randomNumber = random.Next(4,6);
            Console.Write("Breathe in ...");
            for (int i = randomNumber; i > 0; i--  )
            {
                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            for (int j=randomNumber; j>0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            currentTime = DateTime.Now;
              
        }
        Console.WriteLine("Well done!!");      
             
    }

}