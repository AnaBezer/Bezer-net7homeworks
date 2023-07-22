using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public abstract class Shape
{
    public Shape()
    {
        this.Area = 0;
    }
     
    public string Color { get; set; }
    public double Area { get; set; }


    public abstract void CalculateArea();
  
    public virtual double GetPerimeter()
    {
        return 0;
    }

}

public class Rectangle : Shape
{
    public Rectangle(string color, double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }
    private double Width { get; set; }
    private double Height { get; set; }

    public override void CalculateArea()
    {
        this.Area = this.Width * this.Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (this.Width + this.Height);
    }

    public string GetPerimeter(string unit)
    {
        double perimeter = GetPerimeter();

        if (unit == "inches")
        {
            perimeter = perimeter * 39.26;
        }

        if (unit == "feet")
        {
            perimeter = perimeter * 3.28;
        }

        return $"Perimeter: {perimeter} {unit}";
    }
}

public class Circle : Shape
{
    public Circle(string color, double radius)
    {
        this.Radius = radius;
    }

    private double Radius;

    public override void CalculateArea()
    {
        this.Area = Math.PI * Math.Pow(this.Radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public string GetPerimeter(string unit)
    {
        double circumference = GetPerimeter();

        if (unit == "inches")
        {
            circumference = circumference * 39.26;
        }

        if (unit == "feet")
        {
            circumference = circumference * 3.28;
        }

        return $"Perimeter: {circumference} {unit}";
    }
}






