using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myGoal = new Menu();
        SimpleGoal mySimpleGoal =  new SimpleGoal();
        EternalGoal myEternalGoal = new EternalGoal();
        ChecklistGoal myChecklistGoal = new ChecklistGoal();
        Points myPoints = new Points();
        myPoints.DisplayTotalPoints();
        int option = myGoal.DisplayMenu();
        bool keepPlaying = true;
        int simpleCounter = -1;
        int checklistCounter = -1;
        // otro contador para checklist
        int counterGoals = -1;
        while (keepPlaying == true)
        {
            if(option == 1)
            {
                
                
                int goalTypeOption = myGoal.DisplayTypeGoals();
                if (goalTypeOption == 1)
                {
                    simpleCounter += 1;
                    int getSimplePoint = mySimpleGoal.DisplayPrompts();
                    string name = mySimpleGoal.GetGoalName(simpleCounter);
                    myPoints.AddGoalName(name);
                    myPoints.AddGoalPoints(getSimplePoint);
                    
                }else if(goalTypeOption == 2){
                    myEternalGoal.DisplayPrompts();
                    

                }else if(goalTypeOption == 3){
                    checklistCounter += 1;
                    int getChecklistPoint = myChecklistGoal.DisplayPrompts();
                    string name = myChecklistGoal.GetGoalName(checklistCounter);
                    myPoints.AddGoalName(name);
                    myPoints.AddGoalPoints(getChecklistPoint);
                }


                myPoints.DisplayTotalPoints();
                option = myGoal.DisplayMenu();
                keepPlaying = true;

            }else if(option == 2)
            {

                myGoal.DisplayGoals();
                mySimpleGoal.DisplayGoals();
                myEternalGoal.DisplayGoals();
                myChecklistGoal.DisplayGoals();

                myPoints.DisplayTotalPoints();
                option = myGoal.DisplayMenu();
                keepPlaying = true;
            }else if(option == 3)
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
                    int lenghtSimpleGoalname = mySimpleGoal.GetLenghtList();

                    int lenghtChecklistGoalName = myChecklistGoal.GetLenghtList();

                    int lenghtEternalGoalName = myEternalGoal.GetLenghtList();
                    for (int i = 0; i <= lenghtSimpleGoalname -1; i++)
                    {
                        string goalType = mySimpleGoal.GetGoalType(i);
                        string goalName = mySimpleGoal.GetGoalName(i);
                        string goalDescription = mySimpleGoal.GetGoalDescription(i);
                        int goalPoint = mySimpleGoal.GetGoalPoints(i);
                        bool goalComplete = mySimpleGoal.GetRecord(i);
                        outputFile.WriteLine($"Date: {dateText},{goalType},{goalName},{goalDescription},{goalPoint},{goalComplete}");
                    }
                    for (int i = 0; i <= lenghtEternalGoalName -1; i++)
                    {
                        string goalType = mySimpleGoal.GetGoalType(i);
                        string goalName = mySimpleGoal.GetGoalName(i);
                        string goalDescription = mySimpleGoal.GetGoalDescription(i);
                        outputFile.WriteLine($"Date: {dateText},{goalType},{goalName},{goalDescription} ");
                    }
                    for (int i = 0; i <= lenghtChecklistGoalName -1; i++)
                    {
                        string goalType = myChecklistGoal.GetGoalType(i);
                        string goalName = myChecklistGoal.GetGoalName(i);
                        string goalDescription = myChecklistGoal.GetGoalDescription(i);
                        int goalPoint = myChecklistGoal.GetGoalPoints(i);
                        bool goalComplete = myChecklistGoal.GetRecord(i);
                        int goalCounter = myChecklistGoal.GetCounterList(i);
                        int goalHowManyTimes = myChecklistGoal.GetHowManyTimes(i);
                        int goalBonus = myChecklistGoal.GetBonus(i);
                        outputFile.WriteLine($"Date: {dateText},{goalType},{goalName},{goalDescription},{goalPoint},{goalComplete},{goalCounter},{goalHowManyTimes},{goalBonus}");
                    }

                }
                Console.WriteLine("The journey has been already saved");       
                myPoints.DisplayTotalPoints();
                option = myGoal.DisplayMenu();
                keepPlaying = true;
            }else if(option == 4)
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    int lenghtParts = parts.Count();
                    for (int part = 0; part < lenghtParts; part++)
                    {
                        string sentence = parts[part];
                        Console.Write($"{sentence} ");
                        myGoal.CreateGoal(sentence);
                    }
                    
                }
                Console.WriteLine("----------------------");
                Console.WriteLine("The file has already loaded");
                Console.WriteLine("----------------------");
                myPoints.DisplayTotalPoints();
                option = myGoal.DisplayMenu();
                keepPlaying = true;
            }else if(option == 5)
            {
                Console.Write("Write the name of the goal you want to mark as complete: ");
                string goalCompleted = Console.ReadLine();
                Console.Write("Write the name of the goal type: ");
                string type = Console.ReadLine();
                
                
                
                if (type == "Simple Goal")
                {
                    mySimpleGoal.ChangeRecordEvent(goalCompleted, 0);
                    myPoints.ChangeRecordEvent(goalCompleted, 0);
                }else if (type == "Eternal Goal")
                {
                    myEternalGoal.ChangeRecordEvent(goalCompleted, 0);
                }else if (type == "Checklist Goal")
                {
                    // Obtener el bonus.
                    int indexName = myChecklistGoal.GetIndexName(goalCompleted);
                    int getBonus = myChecklistGoal.GetBonus(indexName);
                    // este contador es para obtener el numero de metas de Checklist goals
                    counterGoals += 1;
                    int howmanytimes = myChecklistGoal._howManyTimes[indexName];
                    howmanytimes = howmanytimes -1;
                    int counterChecklistGoal = myChecklistGoal._counterList[indexName];
                    if (counterChecklistGoal < howmanytimes )
                    {
                        myChecklistGoal.ChangeRecordEvent(goalCompleted, 0);
                        myPoints.ChangeRecordEvent(goalCompleted, 0); 
                    }else if (counterChecklistGoal == howmanytimes)
                    {
                        myChecklistGoal.ChangeRecordEvent(goalCompleted, 0);
                        myPoints.ChangeRecordEvent(goalCompleted, getBonus);
                    }

                }
                
                
                
                
                

                myPoints.DisplayTotalPoints();
                option = myGoal.DisplayMenu();
                keepPlaying = true;
            }else if(option == 6)
            {
                Console.WriteLine("Thank you for using the Goal Tracker!");
                keepPlaying = false;
            }

        }
    }
}