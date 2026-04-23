using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Square : Polygon
    {
        public Square(int width) // this is the constructor of the Square class, it takes an integer parameter width and assigns it to the Width property of the Polygon class
        {
            Width = width;
        }
        public override double Area() // this is the implementation of the abstract method area() in the Square class
        {
            // Math.Pow(Width, 2); // this is another way to calculate the area of a square using the Math.Pow method, which raises the width to the power of 2
            return Width * Width; // the area of a square is width * width
        }
    }
}
