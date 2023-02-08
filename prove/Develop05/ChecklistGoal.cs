public class ChecklistGoal : Goal 
{
    public List<int> _howManyTimes = new List<int>();
    public List<int> _bonusPoints = new List<int>();
    public List<int> _counterList = new List<int>();

    



    public int GetCounterList(int i)
    {
        return _counterList[i];
    }
    public int GetBonus(int i)
    {
        int bonusPoints = _bonusPoints[i];
        return bonusPoints;
    }
    public int GetHowManyTimes(int i)
    {
        return _howManyTimes[i];
    }





    
    public override int DisplayPrompts()
    {
        int counter1 = 0;
        _counterList.Add(counter1);
        AddGoalType("Checklist Goal");
        AddRecord(false);
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        AddGoalName(goalName);

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        AddGoalDescription(goalDescription);

        Console.Write("What is the amount of points associated with this goal? ");
        string getUSerInput = Console.ReadLine();
        int goalPoint = int.Parse(getUSerInput);
        AddGoalPoints(goalPoint);

        Console.Write("How many times do you need to complete this goal for a Bonus?");
        string getUSerInput2 = Console.ReadLine();
        int  howmanytimes = int.Parse(getUSerInput2);
        _howManyTimes.Add(howmanytimes);

        Console.Write("What is the amount of points for the bonus? ");
        string getUSerInput3 = Console.ReadLine();
        int  bonusPoint = int.Parse(getUSerInput3);
        _bonusPoints.Add(bonusPoint);
        return goalPoint;
    }
    public override void DisplayGoals()
    {
        int lenght = GetLenghtList();
        
        
        for(int i = 0 ; i < lenght; i++)
        
            {
                bool record = GetRecord(i);

                
                if (record == false)
                {
                    int counter = _counterList[i];
                    int times = _howManyTimes[i];
                    if ( counter == 0)
                    {

                        int newCounter =  _counterList[i] * 0;
                        string mark = " ";
                        string goalType = GetGoalType(i);
                        string name = GetGoalName(i);
                        string description = GetGoalDescription(i); 
                        int point = GetGoalPoints(i);
                        int howManyTimes = _howManyTimes[i];
                        int bonus = _bonusPoints[i];
                        Console.WriteLine($"[{mark}]{goalType}-- {name }: [{description}] - Points: {point} - Complete [{newCounter}/{howManyTimes}] to get the Bonus:{bonus}");
                    }else if (counter > 0 && counter < times)
                    {
                        int newCounter =  _counterList[i] * 1;
                        
                        string mark = " ";
                        string goalType = GetGoalType(i);
                        string name = GetGoalName(i);
                        string description = GetGoalDescription(i); 
                        int point = GetGoalPoints(i);
                        int howManyTimes = _howManyTimes[i];
                        int bonus = _bonusPoints[i];
                        Console.WriteLine($"[{mark}]{goalType}-- {name }: [{description}] - Points: {point} - Complete [{newCounter}/{howManyTimes}] to get the Bonus:{bonus}");
                    }else if (counter == times)
                    {
                        int newCounter =  _counterList[i] * 1;
                        
                        string mark = "X";
                        string goalType = GetGoalType(i);
                        string name = GetGoalName(i);
                        string description = GetGoalDescription(i); 
                        int point = GetGoalPoints(i);
                        int howManyTimes = _howManyTimes[i];
                        int bonus = _bonusPoints[i];
                        Console.WriteLine($"[{mark}]{goalType}-- {name }: [{description}] - Points: {point} - Complete [{newCounter}/{howManyTimes}] to get the Bonus:{bonus}");
                    }
                    
                
                }else if(record == true)
                {
                    int times = _howManyTimes[i] -1;
                    int counter = _counterList[i];
                    if (counter < times)
                    {
                        int newCounter = _counterList[i];
                        newCounter += 1;
                        _counterList[i] = newCounter;
                        string goalType = GetGoalType(i);
                        string name = GetGoalName(i);
                        string description = GetGoalDescription(i); 
                        int point = GetGoalPoints(i);
                        int howManyTimes = _howManyTimes[i];
                        
                        int bonus = _bonusPoints[i];
                        Console.WriteLine($"[ ]{goalType}-- {name }: [{description}] - Points: {point} - Complete [{newCounter}/{howManyTimes}] to get the Bonus:{bonus}");
                        ChangeRecordItem(i, false);
                    }else if (counter == times)
                    {
                        int newCounter = _counterList[i];
                        newCounter += 1;
                        _counterList[i] = newCounter;
                        string goalType = GetGoalType(i);
                        string name = GetGoalName(i);
                        string description = GetGoalDescription(i); 
                        int point = GetGoalPoints(i);
                        int bonus = _bonusPoints[i];
                        int howManyTimes = _howManyTimes[i];
                        Console.WriteLine($"[X]{goalType}-- {name }: [{description}] - Points: {point} - Complete [{newCounter}/{howManyTimes}] to get the Bonus:{bonus}");
                        ChangeRecordItem(i, false);
                    }
                    
                }
                
            }
        // int lenght = GetLenghtList();
        // for(int i = 0 ; i < lenght; i++)
        //     {string goalType = GetGoalType(i);
        //     string name = GetGoalName(i);
        //     string description = GetGoalDescription(i);
        //     int point = GetGoalPoints(i);
        //     int howManyTimes = _howManyTimes[i];
        //     int bonus = _bonusPoints[i];
        //     Console.WriteLine($"--{goalType}-- {name }: [{description}] - Points: {point} - Complete [0/{howManyTimes}] to get the Bonus:{bonus}");
        //     }
    }
    public override void ChangeRecordEvent(string name, int bonus)
    {
        int indexName = GetIndexName(name);
        ChangeRecordItem(indexName, true);

        int lenght = GetLenghtList();         
    }

    
}