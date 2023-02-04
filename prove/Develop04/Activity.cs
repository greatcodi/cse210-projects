public class Activity
{

    private string _activity;
    private int _time;
    

    public Activity (string activity, int time)
    {
        _activity = activity;
        _time = time;
    }
    public Activity ()
    {
        _activity = "";
    }





    public int GetMenu()
    {
        Console.Write("Menu Options:\n\r    1. Start breathing activity\n\r    2. Start reflecting activity\n\r    3. Start listing activity\n\r    4. Quit\n\rSelect a choice from the menu: ");
        string input = Console.ReadLine();
        int option = int.Parse(input);
        Console.Write(option);
        return option;
    }
    public string GetActivity()
    {
        return _activity;
    }
    public int GetTime()
    {
        return _time;
    }
    public void SetTime(int time)
    {
        _time = time;
    }
    public void TakeAPause()
    {
        int timeMilliseconds = _time * 1000;
        
        Thread.Sleep(timeMilliseconds);
    }
    public void DisplayAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("—"); // Replace it with the - character}
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
    public void DisplayTimer()
    {
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
    }
    public void FinalMessage()
    {
        Console.WriteLine($"You have completed another {_time} seconds of the {_activity} Activity.");
    }
}