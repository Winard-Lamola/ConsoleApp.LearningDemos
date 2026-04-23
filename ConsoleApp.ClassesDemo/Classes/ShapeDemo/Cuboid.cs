using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo;

public class Cuboid : Polygon, I2DShape, I3DShape
{
    public Cuboid(double width, double length, double height)
    {
        Width = width;
        Length = length;
        Height = height;
    }
    public double Length { get; set; }
    public double Height { get; set; } 
    public override double Area()
    {
        return 2 * (Length * Width + Length * Height + Width * Height); // the surface area of a cuboid is 2 * (length * width + length * height + width * height)
    }

    public double Perimeter()
    {
        return 4 * (Length + Width + Height); // the perimeter of a cuboid is 4 * (length + width + height)
    }

    public double Volume()
    {
        return Length * Width * Height; // the volume of a cuboid is length * width * height
    }
}
