Console.WriteLine("********************** - Methods - ******************************");
// void methods - complete a task without returning a value
void PrintName()
{
    //Method body - the code that defines what the method does
    Console.WriteLine("Method body - the code that defines what the method does");
}

// value returning methods - perform a task and return a value
int GetFiveYearsAgo()
{
    //return DateTime.Now.Year - 5;
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

Console.WriteLine("********************** - Methods with Parameters - ******************************");
// method signature - the method's name and parameter list
void PrintMessage(string message)
{
    Console.WriteLine("He said:" + message);
}

int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

Console.WriteLine("********************** - methods with optional parameters  - ******************************");
// methods with optional parameters - paremeters is not required when calling the method, and will use a default value if not provided
int GetFutureOrPastYear(int yearsFromNow = 0)
{
    int futureOrPastYear = DateTime.Now.AddYears(yearsFromNow).Year;
    return futureOrPastYear;
}
Console.WriteLine("********************** - methods with nullable parameters  - ******************************");
// methods with nullable parameters
void PrintNullableMessage(string? message, int? count)
{
    //if (string.IsNullOrEmpty(message))
    //{
    //    message = "Default message";
    //}

    // using the null-coalescing assignment operator to assign a default value if message is null or empty ??= is a shorthand for the above if statement
    message ??= "Default message";

    //if (!count.HasValue)
    //{
    //    count = 1; // default count
    //}
    // using the null-coalescing assignment operator to assign a default value if count is null or empty ??= is a shorthand for the above if statement
    count ??= 1; // default count   

    for (int i = 0; i < count.Value; i++)
    {
        Console.WriteLine(message);
    }
}


/* Function Calls */
PrintName(); // calling the method to execute its code
int fiveYearsAgo = GetFiveYearsAgo(); // calling the method and storing its return value
Console.WriteLine($"Five years ago was: {fiveYearsAgo}"); // output the result of the method call

/*calling the method with a parameter output*/
Console.WriteLine("Calling the method with a parameter output:");
Console.WriteLine("Enter a message to print:");
string userMessage = Console.ReadLine();
PrintMessage(userMessage); // calling the method with a user input parameter

Console.WriteLine("Enter a year to calculate the difference from the current year:");
Console.WriteLine("Enter a year");
int userYearInput = Convert.ToInt32(Console.ReadLine());
int yearDifference = GetYearDifferenceWithParams(userYearInput);
Console.WriteLine($"The difference between the current year and {userYearInput} is: {yearDifference} years.");

Console.WriteLine("********************** - methods with optional parameters Output - ******************************");
Console.WriteLine("Enter the number of years to calculate a future or past year (positive for future, negative for past):");
int yearsFromNowInput = Convert.ToInt32(Console.ReadLine());
var futureOrPastYear = GetFutureOrPastYear(yearsFromNowInput);
Console.WriteLine($"The year that is {yearsFromNowInput} years from now is: {futureOrPastYear}.");

var futureOrPastYearDefault = GetFutureOrPastYear();
Console.WriteLine($"The year that is {yearsFromNowInput} years from now is: {futureOrPastYearDefault}.");

Console.WriteLine("********************** - methods with nullable parameters Output - ******************************");
PrintNullableMessage(null, null); // calling the method without parameters, will use default values
PrintNullableMessage("Hello, World!", 5); // calling the method with a message but no count, will use default count


