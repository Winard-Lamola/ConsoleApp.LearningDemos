using ConsoleApp.ClassesDemo.Classes.ShapeDemo;
using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length) // this is the constructor of the Rectangle class, it takes two integer parameters width and length and assigns them to the Width and Length properties of the Polygon class
        {
            Width = width;
            Length = length;
        }
        public double Length { get; set; }
        public override double Area() // this is the implementation of the abstract method area() in the Rectangle class
        {
            return Length * Width; // the area of a rectangle is length * width
        }

        public double Perimeter()
        {
            return 2 * (Width + (double)   Length); // the perimeter of a rectangle is 2 * (width + length)
           // return (2 * Width) + (2 * Lenth); // this is another way to calculate the perimeter of a rectangle using the distributive property of multiplication
        }

        double I2DShape.Perimeter()
        {
            return Perimeter();
        }

        public override string GetShapeName() // this is the override of the virtual method GetShapeName() in the Rectangle class, it returns "Rectangle" instead of "Polygon"
        {
            return base.GetShapeName() + " - Rectangle"; // this will call the GetShapeName method of the base class (Polygon) and concatenate it with " - Rectangle" to return "Polygon - Rectangle"
        }
    }
}
