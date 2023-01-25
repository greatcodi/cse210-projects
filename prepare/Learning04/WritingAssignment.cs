public class WritingAssignment : Assignment
{
    private string _title;
    // constructor that inherits from Assignment
    public WritingAssignment (string studentName, string topic, string title) : base(studentName,topic)
    {
        _title = title;
    }



    public string GetWritingInformation ()
    {
        string name = GetStudentName();
        return $"{_title} by {name}";
    }


}