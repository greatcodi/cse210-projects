public class Menu : Goal
{

    public  int DisplayMenu()
    {
        Console.Write("Menu options:\n\r   1. Create New Goal\n\r   2. List Goals\n\r   3. Save Goals\n\r   4. Load Goals\n\r   5. Record Event\n\r   6. Quit\n\rSelect a choice from the menu: ");
        string getUserInput = Console.ReadLine();
        int option = int.Parse(getUserInput);
        return option;
    }
    public override int DisplayPrompts()
    {
        return 0;
    }
    public override void DisplayGoals()
    {
        
    }
    public override void ChangeRecordEvent(string name, int bonus)
    {
            
    }
    
}