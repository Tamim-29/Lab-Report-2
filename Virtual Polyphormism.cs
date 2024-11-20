using System;
public class Shape{
  public virtual void Draw()
  {
    Console.WriteLine("Drawing a Shape");
  }
}
public class Triangle:Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a Triangle");
  }
}
public class Rectangle:Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a Rectangle");
  }
}
public class Prism:Shape
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
    Shape shape1=new Shape();
    Triangle shape2=new Triangle();
    Prism shape3=new Prism();
    shape1.Draw();
    shape2.Draw();
    shape3.Draw();
    
     
  }
}
