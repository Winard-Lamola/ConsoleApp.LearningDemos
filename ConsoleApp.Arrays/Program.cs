Console.WriteLine("********************* - Arrays - ******************");

// Tell me how many students and grade are to be entered
Console.Write("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Decalre Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// 5 space addresses/indexes - 0, 1, 2, 3, 4
// If n is the size of the array, then your array hass addresses between 0 to is n-1

// Add values to the Fixed Size array
//grades[0] = 90;
//grades[1] = 80;
//grades[2] = 45;
//grades[3] = 75;
//grades[4] = 60; 

for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Enter students names: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Display the values in the fixed size array
Console.Write("Grades Entered via for loop are: ");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Student: " + students[i] + " Grade is: " + grades[i]);
    //Console.WriteLine(students[i]);
    //Console.WriteLine(grades[i]);
}

//// Display the values in the List - foreach loop
//foreach (int grade in grades)
//{
//    Console.WriteLine(grade);
//}

//// Declare variable sized array
//string[] studentNames = new string[] { "Dubb", "Jackson", "etc...." };

//// Add values to the variable sized array
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write("Enter Names: ");
//    studentNames[i] = Console.ReadLine();
//}

//// Display the values in the variable sized array
//Console.WriteLine("Names Entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}

//// Display the values in the List - foreach loop
//foreach (int grade in grades)
//{
//    Console.WriteLine(grade);
//}
