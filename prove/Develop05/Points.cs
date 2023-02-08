public class Points : Goal
{
    public override void ChangeRecordEvent(string name, int bonus)
    {
        // Here i am getting and index that is negative and that make my code worong
        int indexName = GetIndexName(name);
        int getPoint =  GetGoalPoints(indexName);
        CalculatePoints(getPoint, bonus);
    }
    public void DisplayTotalPoints()
    {
        int totalPoints = GetTotalPoints();
        Console.WriteLine($"You have {totalPoints} points.\n\r");
        Console.WriteLine($"");
    }
    public override int DisplayPrompts()
    {
        return 0;
    }
    public override void DisplayGoals()
    {
    }
}