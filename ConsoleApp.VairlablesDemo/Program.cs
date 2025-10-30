// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
 text - string
 integers - int
 decimal - double, float, decimal
 logical - bool
*/


// string
string name = "Tlou Lamola";

Console.WriteLine(name);
Console.WriteLine("I am " + name); //String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given the name {0}", name); // Formatted String

// integer
int age = 29;
int retirementYearsLeft = 36;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("I am " + age + " years old");
Console.WriteLine("My retirement age is:" + retirementAge);

// boolean
bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);