using ConsoleApp.ClassesDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public class Teacher : Person
{
    public void GeneareIdNumber()
    {
        // Implementation for generating ID number
        //_idNumber = "TCH-" + DateOfBirth.ToString("yyyyMMdd") + GenerateIdNumber();
        _idNumber =PersonHelper.GenerateINumber("TCH") + DateOfBirth.ToString("yyyyMMdd");


    }
}
