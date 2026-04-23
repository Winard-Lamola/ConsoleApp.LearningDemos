using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Sphare : ICircularShape, I3DShape 
    {
        public Sphare(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; } 
        public double Circumference()
        {
            return 2 * Math.PI * Math.Pow(Radius, 3); // the circumference of a sphere is 2 * pi * radius^3
        }

        public double Volume()
        {
            //return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3); // the volume of a sphere is (4/3) * pi * radius^3
            return (4 / 3) * Math.PI * Radius ; // this is another way to calculate the volume of a sphere, but it will not give the correct result because it will perform integer division and return 0 instead of 0.3333
        }
    }
}
