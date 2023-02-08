public class EternalGoal : Goal
{
    
    public override int DisplayPrompts()
    {
        AddGoalType("Eternal Goal");
        AddRecord(false);
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        AddGoalName(goalName);

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        AddGoalDescription(goalDescription);
        return 0;

        // Console.Write("What is the amount of points associated with this goal? ");
        // string getUSerInput = Console.ReadLine();
        // int goalPoint = int.Parse(getUSerInput);
        // AddGoalPoints(goalPoint);
    }
    public override void DisplayGoals()
    {
        
        int lenght = GetLenghtList();
        for(int i = 0 ; i < lenght; i++)
        
            {
                bool record = GetRecord(i);

                if (record == false)
                {
                    string mark = " ";
                    string goalType = GetGoalType(i);
                    string name = GetGoalName(i);
                    string description = GetGoalDescription(i);
                    Console.WriteLine($"[{mark}]{goalType}-- {name }: [{description}]");
                }else if(record == true)
                {
                    
                    string mark = "X";
                    string goalType = GetGoalType(i);
                    string name = GetGoalName(i);
                    string description = GetGoalDescription(i);
                    Console.WriteLine($"[{mark}]{goalType}-- {name }: [{description}]");
                }
                
            }

        // for(int i = 0 ; i < lenght; i++)
        //     {string goalType = GetGoalType(i);
        //     string name = GetGoalName(i);
        //     string description = GetGoalDescription(i);
        //     Console.WriteLine($"--{goalType}-- {name }: [{description}]");
    }
    public override void ChangeRecordEvent(string name, int bonus)
    {
        int indexName = GetIndexName(name);
        ChangeRecordItem(indexName, true);

        int lenght = GetLenghtList();         
    }
    
}