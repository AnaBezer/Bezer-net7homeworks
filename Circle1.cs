using System;

public class Circle1 : IShape, IColor
{
    public Circle1(double radius)
    {
        this.Radius = radius;
        this.Color = "Black";
    }
    public Circle1(double radius, string color)
    {
        this.Radius = radius;
        this.Color = color;
    }

    private double Radius { get; set; }

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

        return $"Area: {area} {unit}";
    }
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(this.Radius, 2);
    }

    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
}
