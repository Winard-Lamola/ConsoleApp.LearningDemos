
using System;

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
  Math Operations and Operators
*/
//Addition
int sum = num1 + num2;

//Multiplication
int product = num1 * num2;

//Division
int quotient = num1 / num2;

//Subtraction
int difference = num1 - num2;

//Modulus Remainder
int mod = num1 % num2;

//Print Output
Console.WriteLine("------------------- Math Results -------------------");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Produdct: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("------------------- End Math Results -------------------");
Console.WriteLine();
/*
  Logic Operations & Operators
*/
bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isNotEqualTo = num1 != num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
Console.WriteLine("------------------- Logic Results -------------------");
Console.WriteLine();
Console.WriteLine($"Is greater than: {isGreaterThan}");
Console.WriteLine($"Is less than: {isLessThan}");
Console.WriteLine($"Is Is equal to: {isEqualTo}");
Console.WriteLine($"Is not equal to: {isNotEqualTo}");
Console.WriteLine($"Is greater than or equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is less than or equal to: {isLessThanOrEqualTo}");
Console.WriteLine();
Console.WriteLine("------------------- End Logic Results -------------------");
/*
  Assignment Operations & Operators
*/
//int randomValue = 5;

Console.Write("Please enter the random value for assignmnet operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increaseValue = num1 + randomValue;

//num1 = num1 + 5;

Console.WriteLine("--------------- Assignment Results ---------------");
Console.WriteLine();
//num1 = num1 + randomValue;
num1 += randomValue;
Console.WriteLine($"Num1 increased by {randomValue}: {num1}");
//num1 = num1 - randomValue;
num1 -= randomValue;
Console.WriteLine($"Num1 reduced by {randomValue}: {num1}");
//num1 = num1 / randomValue;
num1 /= randomValue;
Console.WriteLine($"Num1 divided by {randomValue}: {num1}");
//num1 = num1 %= randomValue;
num1 %= randomValue;
Console.WriteLine($"Num1 mod by {randomValue}: {num1}");
//num1 = num1 * randomValue;
num1 *= randomValue;
Console.WriteLine($"Num1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("------------- End Assignment Results -------------");

