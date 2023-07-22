using System;

public class Rectangle1 : IShape, IColor
{
    public Rectangle1(double width, double height)
    {
        this.Width = width;
        this.Height = height;
        this.Color = "Black";
    }
    public Rectangle1(double width, double height, string color)
    {
        this.Width = width;
        this.Height = height;
        this.Color = color;
    }
    private double Width { get; set; }
    private double Height { get; set; }

    public double CalculateArea()
    {
        return this.Width * this.Height;
    }
    public string CalculateArea(string unit)
    {
        double area = CalculateArea();

        if (unit == "inches")
        {
            area = area * 39.26;
        }

        if (unit == "feet")
        {
            area = area * 3.28;
        }

        return $"Perimeter: {area} {unit}";
    }

    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
}
