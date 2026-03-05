// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("******************* - String Manupilation - ***********************");


// Initialize with a regular string literal
string s1 = "This is a literal string s1";
String s2 = "This is a literal string s2";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");
// Declare without initializing. (Possible null exception)
string s3;
//Console.WriteLine($"{nameof(s3)}: {s3}"); //syntax error. s3 nedds value before it can used.
// Initialize to null. (Possible null exception)
string? s4 = null;
Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize as an empty string
string s5 = string.Empty;
string s6 = " ";
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");
// Escape sequences and characters
// She said, "I have your phone number"
string sentance = "She said, \"I have your phone number\" \r\nThis is the next line";
Console.WriteLine($"{nameof(sentance)}: {sentance}");

// Verbatim string literal
string oldPath = "C:\\program files \\programfolder\\";
string newPath = @"C:\program files \programfolder\";

Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";
//path = "new value; Illigal operation against a cosntant"
s1 = "a new string";
Console.WriteLine($"{nameof(path)}: {path}");
Console.WriteLine($"{nameof(s1)}:  {s1}");

// Raw string literals
string rawLiteral = """She said, "I have your phone number" """;
string rawLiteral1 = """"
     
     She said, "I have your phone number"
     This is the next line
     And another one
     Path = "C:\program files \programfolder\"
     """";
Console.WriteLine($"{nameof(rawLiteral)}:  {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}:  {rawLiteral1}");

// Concatenation and interpolation
s1 = s1 + s2;   // Concatenation
s1 += s2;       // Shorthand concatenation
Console.WriteLine($"{nameof(s1)}: {s1}");

string newString = $"{s1} {s2} Some random literal text"; // Interpolation
string newString1 = $"{s1} {s2} Some random literal text"; // Fixed redundancy
string newString2 = String.Format("Literal string {0} {1}", s1, s2); // Format method

Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");


/* String manupulation methods . Sometines it just assessment */

// Null or empty checks
// FInd the length of a string
Console.WriteLine($"{nameof(s1)} has length of {s1.Length}");
Console.WriteLine($"{nameof(s6)} has length of {s6.Length}");
//Console.WriteLine($"{nameof(s4)} has length of {s4.Length}"); // Will cause null exception

//if (string.IsNullOrEmpty(s4) == false)
if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has length of {s4.Length}");
}
else
{
    Console.WriteLine($"{nameof(s4)} is null or empty");
}


if (string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has length of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");


// Splitting strings
var splitStrings = s2.Split(' ');
for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine($"{splitStrings[i]}");
}

// Replace
string replacements1 = s1.Replace('s', 'P');
Console.WriteLine($"{nameof(replacements1)}: {replacements1}");
string replacements2 = s1.Replace("string", "G.O.A.T");
Console.WriteLine($"{nameof(replacements2)}: {replacements2}");

// Convert to string
// Convert double to string
string salary = 3589642.50.ToString();
Console.WriteLine($"{nameof(salary)}: {salary}");

// Convert int to string
int value = 27542;
string strValue = value.ToString();
Console.WriteLine($"{nameof(value)}: {value}");
Console.WriteLine($"{nameof(strValue)}: {strValue}");

// Convert bool to string
bool option = false;
string strOption = option.ToString();
Console.WriteLine($"{nameof(option)}: {option}");
Console.WriteLine($"{nameof(strOption)}: {strOption}");

// Changing Formatting
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary)+ " : " + value.ToString("C"));
// DateTime formatting 
DateTime now = DateTime.Now;
Console.WriteLine($"{nameof(now)} (default): {now.ToString()}");
Console.WriteLine($"{nameof(now)} (short date): {now.ToString("d")}");
Console.WriteLine($"{nameof(now)} (long date): {now.ToString("D")}"); 
Console.WriteLine($"{nameof(now)} (custom): {now.ToString("yyyy-MM-dd HH:mm:ss")}");

Console.WriteLine("******************* End of Program ***********************");

// Prevent console from closing immediately
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

