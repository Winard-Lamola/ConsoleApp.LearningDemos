using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Interfaces
{
    public interface I2DShape
    {
        double Perimeter(); // this is an abstract method, it does not have a body and must be implemented by the classes that implement this interface
    }
}
