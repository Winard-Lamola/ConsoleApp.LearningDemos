// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If.....Else....Statement - Decide to print pass or fail based on input
Console.WriteLine("-------------- Simple If Results -------------------");
if (grade >= 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affair's office");
}
Console.WriteLine("-------------- Simple If Results End -------------------");

// Simple If.....Else....Statement - Decide to print pass or fail based on input

Console.WriteLine("-------------- Complex IF..ELSE IF Results -------------------");

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{

    Console.WriteLine("Student has failed - F");

}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}


Console.WriteLine("-------------- Complex IF..ELSE IF Results End -------------------");


// Ternary Operator - Used to assign a value to a variable based on a condition.
Console.WriteLine("------------- Ternary Operators Result -------------");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Staus is: {passStatus}");

Console.WriteLine("------------- Ternary Operators Result End -------------");

// Switch statements  -  used to evaluate a value and take an action
Console.WriteLine("***************Switch Statement Results ****************");

/*
* Write a program to accept an integer as the day of the week and print the apporpiate message as outlined below.
1 - Sunday
2 - Monday
3 - Tuesday
4 - Wednesday (Hump Day!)
5 - Thursday
6 - Friday (TGIF!!)
7 - Saturday (Beach Day!!!)
*/

Console.Write("Please enter the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        Console.WriteLine("(Jaiva nabo yttie)");
        // more code
        break;
    case 2:
        Console.WriteLine("Monday");
        Console.WriteLine("(Boys' Holiday)");
        // more code
        break;
    case 3:
        Console.WriteLine("Tuesday");
        // more code
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("(Humpday)");
        // more code
        break;
    case 5:
        Console.WriteLine("Thursday");
        Console.WriteLine("(Ladies Night)");
        // more code
        break;
    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("(FMF)");
        // more code
        break;
    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("(Hustle Day)");
        break;

    default:
        Console.WriteLine("invalid day number entered");
        break;
}

Console.WriteLine("***************Switch Statement Results End****************");


// The rest of the application
Console.WriteLine("Thank you for using this program");





