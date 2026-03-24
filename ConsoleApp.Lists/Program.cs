// See https://aka.ms/new-console-template for more information
Console.WriteLine("********************* - Lists - ******************");

// Declare a List
List<int> grades = new List<int>();
List<string> students = new List<string>();
int numberOfGrades = 0;
string studentName;
int gradeCount = 0;   
int @continue;
//var grades = new List<int>();
//List<int> grades2 = new List<int>();

// Add value to the List
//grades.Add(90);
//grades.Add(80);
//grades.Add(45);
//grades.Add(75);
//Console.WriteLine(grades[0]); // 4
//Console.WriteLine(grades[1]); // 3
//Console.WriteLine(grades[2]);
//Console.WriteLine(grades[3]);

do
{
    gradeCount += 1;
    Console.Write("Enter Student Name: ");
    studentName = Console.ReadLine();
    students.Add(studentName);

    Console.Write("Enter Grade: ");
    numberOfGrades = Convert.ToInt32(Console.ReadLine());
    if (numberOfGrades != -1)
    {
        grades.Add(numberOfGrades);
    }

    Console.Write("Do you want to continue? (1 for yes, -1 for no)");
    @continue = Convert.ToInt32(Console.ReadLine());

} while (@continue == 1);

// Display the values in the List - for loop
Console.WriteLine("Grades Entered via for loop are: ");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine("Student: " + students[i] + " Grade is: " + grades[i]);
    //Console.WriteLine(students[i]);
    //Console.WriteLine(grades[i]);
}

//// Display the values in the List - foreach loop
//Console.WriteLine("Grades Entered via foreach loop are: ");
//foreach (int grade in grades)
//{
//    Console.WriteLine(grade);
//}
