using System;

public abstract class Shape
{
    public abstract void Draw(); // Abstract method
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}
public class Prism : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Prism");
    }
}

class Program
{
    static void Main()
    {
        Shape shape1 = new Circle();    // Polymorphism
        Shape shape2 = new Rectangle();// Polymorphism
        Shape shape3 = new Prism();// Polymorphism

        shape1.Draw(); // Calls Circle's Draw()
        shape2.Draw(); // Calls Rectangle's Draw()
        shape3.Draw();// Calls Prism,s Draw()
    }
}
