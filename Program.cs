using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
       var Rectangle = new Rectangle { Width = 20, Height = 5 };

       var Circle = new Circle { Radius = 7 };

        PrintShape(Rectangle);
        PrintShape(Circle);

       void PrintShape(Shape shape)
       {
        Console.WriteLine($"Perimeter: {shape.GetPerimeter()} Area: {shape.GetArea()}");
       }
    }   
    
    
}

abstract class Shape()
{
    public abstract double GetPerimeter();

    public abstract double GetArea();

}

class Rectangle : Shape
{
    public float Height { get; set; }
    public float Width { get; set; }

    public override double GetPerimeter() => Width * 2 + Height * 2;

    public override double GetArea() => Width * Height;
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetPerimeter() => Radius * 2 * 3.14;

    public override double GetArea() => Radius * Radius * 3.14;
}