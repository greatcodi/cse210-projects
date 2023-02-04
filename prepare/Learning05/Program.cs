using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square mySquare = new Square("blue",5);
        shapes.Add(mySquare);

        Rectangle myRectangle = new Rectangle("red", 5, 2);
        shapes.Add(myRectangle);

        Circle myCircle = new Circle("White", 10);
        shapes.Add(myCircle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}