public class DataBase 
{
    private List<Activity> activities = new List<Activity>();
    
    public void SetActivityList(Activity activity)
    {
        activities.Add(activity);
    }
    public void DisplayActivity()
    {
        foreach(Activity acti in activities)
        {
            Console.WriteLine(acti.GetSummary());
        }
    }
}