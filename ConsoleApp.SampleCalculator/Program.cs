// See https://aka.ms/new-console-template for more information

//// Welcome Message
//Console.WriteLine("******* - Welcome to the sample calculator! - ***********");

// Variable Declarations
int choice = 0;
int num1, num2 = 0;


// Prompt for user input
while (choice != -1)
{
    try
    {
        // Welcome Message
        Console.Clear();
        Console.WriteLine("******* - Welcome to the sample calculator! - ***********");
        // Show calculator options /Show menu
        Console.WriteLine("Please select an operation (-1 to exit the program)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonaccie Sequence");

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the Second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());


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
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }
        // Print output
        Console.WriteLine($"The answer is: {answer}");

    }
    catch (DivideByZeroException)
    {

        Console.WriteLine("Çannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to try again");
        Console.ReadLine();
    }
    Console.WriteLine("******* - Thank you for using sample calculator! - ***********");
}