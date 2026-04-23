// Section 3 Lecture 21
using System.Globalization;
using System.Xml.Serialization;


// Declare variables and Types
char choice = char.MinValue;
string? firstName = string.Empty;
string lastName = string.Empty;
int age;
DateOnly dateOfBirth = new DateOnly();
decimal salary;
char gender = char.MinValue;
bool working = true;

List<Person> persons = new List<Person>();

while (choice != 'E')
{

    //Prompt the user for input
    Console.Write("Please enter your  first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (dd/MM/yyyy): ");
    dateOfBirth = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
        CultureInfo.InvariantCulture);


    Console.Write("Please enter your salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please enter your gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working? (true or false): ");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new(dateOfBirth)
    {
        FirstName = firstName,
        LastName = lastName,
        DateOfBirth = dateOfBirth,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);
    //persons.Add(new Person(dateOfBirth)
    //{
    //    FirstName = firstName,
    //    LastName = lastName,
    //    //DateOfBirth = dateOfBirth,
    //    Gender = gender,
    //    IsWorking = working,
    //    Salary = salary

    //});

    Console.WriteLine("C - Continue | E - Exit");
    choice = Convert.ToChar(Console.ReadLine());

}

foreach (var person in persons)
{
    // Output the reults to the user using String interpolation
    Console.WriteLine();
    Console.WriteLine(person.ToString());
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Salary: {person.Salary:C}");
    Console.WriteLine($"Gender: {person.Gender}");
    Console.WriteLine($"Employed: {person.IsWorking}");
    Console.WriteLine($"Years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Retirement date: {person.GetEstimatedRetirementYear()}");
}