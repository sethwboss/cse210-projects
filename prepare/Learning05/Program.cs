using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("blue", 5, 10);
        shapes.Add(rectangle);
        Circle circle = new Circle("blue", 5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            
            Console.WriteLine($"The area for {shape} is {area}");
            Console.WriteLine($"The color for {shape} is {color}");
        }
    }
}