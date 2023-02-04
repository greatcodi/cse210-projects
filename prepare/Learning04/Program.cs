using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment myTask1 = new MathAssignment("Ricardo Mostacero", "Equations", "Section 6.69", "Problems 6-9");
        Console.WriteLine(myTask1.GetSummary());
        Console.WriteLine(myTask1.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment myTask2 = new WritingAssignment("Alexandra", "The Family","The Family a Proclamation to the world");
        Console.WriteLine(myTask2.GetSummary());
        Console.WriteLine(myTask2.GetWritingInformation());
    }
}
