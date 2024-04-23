using System;
using System.Drawing;

interface Ishape
{
    public double CalculateArea();
    public double CalculatePerimeter();
}

class Rectangle : Ishape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;

    }

    

    public double CalculateArea()
    {
        return Width * Height;
    }
    
    public double CalculatePerimeter()
    {
        return 2 * Height * Width;
    }

}

class Program
{
    public static void Main(string[]args) {

        Rectangle rectangle = new Rectangle(3, 5);

        Rectangle rectangle2 = new Rectangle(3, 5);

        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());
    }
}