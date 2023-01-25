public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;


    // constructor that inherits from the base Assignment class.
    public MathAssignment (string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textBookSection} {_problems}";
    }



}