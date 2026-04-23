using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo;

public abstract class Polygon
{

    public double Width { get; set; }

    public abstract double Area(); // this is an abstract method, it does not have a body and must be implemented by the derived classes

    public virtual string GetShapeName() // this is a virtual method, it has a body and can be overridden by the derived classes
    {
        return "Polygon";
    }

}
