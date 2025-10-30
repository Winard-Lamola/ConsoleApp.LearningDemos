// Section 3 Lecture 21

// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

//Prompt the user for input
Console.WriteLine("Please enter your name");
name = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the reults to the user using String interpolation
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaning: {workingYearsRemaining}");