public class Book 
{
    public int _firstVerse;
    public int _lastVerse;
    public List<string> _scripture = new List<string>()
    {
    "For", "behold,","this", "is", "my", "work", "and", "my","glory", "to" ,
     " bring", "to" ,"pass", "the" ,"immortality" ,"and", "eternal", "life", "of", "man."
    };
    public List<string> _scriptures = new List<string>();
    public List<string> _writingPassages = new List<string>()
    {
        "Moses 1:39 "
    };
    public Book ()
    {
        _firstVerse = 39;
        _lastVerse = 0;
    }
    public Book (int firstVerse)
    {
        _firstVerse = firstVerse;
    }
    public Book (int firstVerse, int lastVerse)
    {
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public void ShowScripture()   
    {

        Terminal myTerminal = new Terminal();
        myTerminal.DisplayTextToTheRight(_writingPassages[0]);
        foreach(string word in _scripture)
        {
            Console.Write($"{word} ");
        }
        myTerminal.Display("");
        myTerminal.Display("");

    }
    public void ClearTerminal()
    {
        Random randomNumber = new Random();
        Console.Clear();
        int items = _scripture.Count();
        for (int i = 1; i < 4; i++ )
        {
            // random index
            int index = randomNumber.Next(items);
            if ( _scripture[index] != "____")
            {
                _scripture[index] = "____";
            }
            else if ( _scripture[index] == "____")
            {
                for (int j = 0; j < (items - 1); j++ )
                {
                    if (_scripture[j] != "____")
                    {
                        _scripture[j] = "____";
                        break;
                    }
                }

            }
        }
        
        
    }

    
}