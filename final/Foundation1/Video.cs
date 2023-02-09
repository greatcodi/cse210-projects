public class Video
{

public string _title;
public string _author;
public int _length;
public List<Comment> comments = new List<Comment>();


public int StoreComments()
{
    
    int counter = 0;
    Console.WriteLine("Comments:");
    foreach (Comment comm in comments)
    {
        counter += 1;
        string commName = comm._name;
        string comment = comm._commment;
        Console.WriteLine ($"   {counter}. {commName} - {comment}");
    }

    return counter;
}
public void DisplayVideoInfo ()
{
    Console.WriteLine ($"Title: {_title}");
    Console.WriteLine ($"Author: {_author}");
    Console.WriteLine($"Seconds of the video: {_length}");
}
public int NumberComments()
{
    int counter = 0;
    foreach (Comment comm in comments)
    {
        counter += 1;
    }
    return counter;

}

}