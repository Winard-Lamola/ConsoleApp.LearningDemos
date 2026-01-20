// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("******* - Welcome to the sample calculator! - ***********");

// Show calculator options /Show menu
Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// Decide which operation is needed based on selected option

/* If Statement*/
//if (choice == 1)
//{
//    /* do addition */
//}
//else if (choice == 2)
//{
//    /* do subtraction */
//}
//else if (choice == 3)
//{
//    /* do multiplication */
//}
//else if (choice == 4)
//{
//    /* do division */
//}
//else
//{
//    Console.WriteLine("Invalid choice");
//}

/* Switch statement*/
int answer = 0;
switch (choice)
{
    case 1:
        answer = num1 + num2;
        break;
    case 2:
        answer = num1 - num2;
        break;
    case 3:
        answer = num1 * num2;
        break;
    case 4:
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("invalid choice");
        break;
}

// Print output
Console.WriteLine($"The answer is: {answer}");
