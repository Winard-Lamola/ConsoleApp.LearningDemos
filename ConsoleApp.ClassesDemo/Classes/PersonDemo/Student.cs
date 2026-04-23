using ConsoleApp.ClassesDemo.Utils;
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public class Student : Person
{
    public void GeneareIdNumber()
    {
        //// Implementation for generating ID number
        //_idNumber = "STU-" + DateOfBirth.ToString("yyyyMMdd") + GenerateIdNumber();
        _idNumber = PersonHelper.GenerateINumber("STU") + DateOfBirth.ToString("yyyyMMdd");
    }

}
