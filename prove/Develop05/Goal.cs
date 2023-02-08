public abstract class Goal
{
    private int _totalPoints;
    private List<string> _goalType = new List<string>();
    private List<string> _name = new List<string>();
    private List<string> _description = new List<string>();
    private List<int> _points = new List<int>();
    private List<bool> _recordEvent = new List<bool>();
    private List<string> _loadedItems = new List<string>();


    public Goal(int totalPoints, string description)
    {
        _totalPoints = totalPoints;
        
    }
    public Goal()
    {
        _totalPoints = 0;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void CalculatePoints(int newpoints, int bonus)
    {
        _totalPoints += newpoints + bonus;
    }
    public void AddPoints(int points)
    {
        _points.Add(points);
    }
    
    public void AddGoalType(string goalType)
    {
        _goalType.Add(goalType);
    }
    public void AddGoalName(string goalName)
    {
        _name.Add(goalName);
    }
    public void AddGoalDescription(string goalDescription)
    {
        _description.Add(goalDescription);
    }
    public void AddGoalPoints(int goalPoint)
    {
        _points.Add(goalPoint);
    }
    public void AddRecord(bool record)
    {
        _recordEvent.Add(record);
    }


    public string GetGoalType(int i)
    {
        return _goalType[i];
    }
    public string GetGoalName(int i)
    {
        return _name[i];
    }
    public string GetGoalDescription(int i)
    {
        return _description[i];
    }
    public int GetGoalPoints (int i)
    {
        return _points[i];
    }
    public bool GetRecord(int i)
    {
        return _recordEvent[i];
    }
    public int GetLenghtList()
    {
        int lenght = _name.Count;
        return lenght;
    }
    
    public int GetIndexName(string name)
    {
        int index = _name.IndexOf(name);
        return index;
    }
    public void ChangeRecordItem (int i, bool trueOrFalse)
    {
        _recordEvent[i] = trueOrFalse;
    }
    public void CreateGoal(string item)
    {
        _loadedItems.Add(item);
    }
    


    

    public int DisplayTypeGoals()
    {
        Console.Write("The types of goals are:\n\r   1. Simple Goal\n\r   2. Eternal Goal\n\r   3. Checklist Goal\n\rWhich type of goal would you like to create? ");
        string getUserInput = Console.ReadLine();
        int option2 = int.Parse(getUserInput);
        return option2;
    }
    

    


    public abstract void ChangeRecordEvent(string name, int bonus);
    public abstract int DisplayPrompts();
    public abstract void DisplayGoals();
    


}