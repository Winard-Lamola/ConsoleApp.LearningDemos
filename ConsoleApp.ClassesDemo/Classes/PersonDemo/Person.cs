// See https://aka.ms/new-console-template for more information
// Define a class

using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public partial class Person
{
    // This is a partial class, it can be split into multiple files and the compiler will combine them into one class
    // This is useful for organizing code and separating concerns
    public Person()
{
        FirstName = string.Empty;
        LastName = string.Empty;
        _taxNumber = string.Empty;
    }


public Person(string firstName, string lastName, string taxNumber)
{
    FirstName = firstName;
    LastName = lastName;
    _taxNumber = taxNumber;
}
// Properties/data members

public string FirstName { get; set; }

public string LastName { get; set; }

public DateOnly DateOfBirth { get; set; }

//Fields/data members
private string _taxNumber;
protected string _idNumber = "N/A";

public void DisplayInfo()
{
        var type = GetType().Name;
        Console.WriteLine($"{type} name: {FirstName} {LastName}");
    //Console.WriteLine($"Date of Birth: {DateOfBirth}");
}

public void PrintInitials()
{
        var type = GetType().Name;
        var initials = $"{FirstName[0]}.{LastName[0]}.";
        Console.WriteLine($"{type} initials: {initials}"); 
}

public void GenerateTaxNumber()
{
    // Implementation for generating tax number
    if (string.IsNullOrEmpty(_taxNumber))
    {
        _taxNumber = GenerateIdNumber();
    }
    else
    {
        Console.WriteLine("Tax number already generated.");
    }


}

public string GetTaxNumber()
{
    return _taxNumber;
}

public string GetIdNumber()
{
    return _idNumber;
}



protected string GenerateIdNumber()
{
    // Implementation for generating ID number
    return RandomNumberGenerator
        .GetInt32(10000000, 99999999)
        .ToString();
}
}

