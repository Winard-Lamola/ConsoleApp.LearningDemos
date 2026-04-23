// See https://aka.ms/new-console-template for more information
using ConsoleApp.ClassesDemo;
using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("******************* -- Classes and Objects -- ***********************");
// Define an object of the type Person
Person person; // this  will be null by default, as it is a reference type

Person baby = new Person(); // this will create an object of type Person and assign it to person
baby.FirstName = "Silent";
baby.LastName = "Moonlight";
baby.DateOfBirth = new DateOnly(1998, 06, 01);

baby.DisplayInfo(); // this will call the DisplayInfo method of the baby object and display the information of the baby
baby.PrintInitials(); // this will call the PrintInitials method of the baby object and display the initials of the baby
baby.GenerateTaxNumber(); // this will call the GenerateTaxNumber method of the baby object and generate a tax number for the baby

var _taxNumber = baby.GetTaxNumber(); // this will call the GetTaxNumber method of the baby object and get the tax number of the baby
Console.WriteLine($"Tax Number: {_taxNumber}"); // this will display the tax number of the baby

var person1 = new Person("Given", "Moks", new DateOnly(2000,03,20));
person1.DisplayInfo();
person1.PrintInitials();

var person2 = new Person("Fatso", "Lets", "741258863");
person2.DisplayInfo();
person2.PrintInitials();
person2.GenerateTaxNumber();
var person2IdNumber = person2.GetIdNumber();
Console.WriteLine($"Person2 ID Number: {person2IdNumber}");

var teacher = new Teacher();
teacher.FirstName = "James";
teacher.LastName = "Brown";
teacher.DateOfBirth = new DateOnly(1985, 9, 25);

teacher.DisplayInfo(); // this will call the DisplayInfo method of the teacher object and display the information of the teacher
teacher.PrintInitials(); // this will call the PrintInitials method of the teacher object and display the initials of the teacher
teacher.GenerateTaxNumber(); // this will call the GenerateTaxNumber method of the teacher object and generate a tax number for the teacher
var teacherTaxNumber = teacher.GetTaxNumber(); // this will call the GetTaxNumber method of the teacher object and get the tax number of the teacher
Console.WriteLine($"Teacher Tax Number: {teacherTaxNumber}"); // this will display the tax number of the teacher
teacher.GeneareIdNumber(); // this will call the GeneareIdNumber method of the teacher object and generate an ID number for the teacher
var teacherIdNumber = teacher.GetIdNumber(); // this will call the GetIdNumber method of the teacher object and get the ID number of the teacher
Console.WriteLine($"Teacher ID Number: {teacherIdNumber}"); // this will display the ID number of the teacher

Student student = new();
student.FirstName = "Silas";
student.LastName = "Nare";
student.DateOfBirth = new DateOnly(2008, 08, 08);

student.DisplayInfo(); // this will call the DisplayInfo method of the student object and display the information of the student
student.PrintInitials(); // this will call the PrintInitials method of the student object and display the initials of the student
student.GenerateTaxNumber(); // this will call the GenerateTaxNumber method of the student object and generate a tax number for the student
var studentTaxNumber = student.GetTaxNumber(); // this will call the GetTaxNumber method of the student object and get the tax number of the student
Console.WriteLine($"Student Tax Number: {studentTaxNumber}"); // this will display the tax number of the student
student.GeneareIdNumber(); // this will call the GeneareIdNumber method of the student object and generate an ID number for the student
var studentIdNumber = student.GetIdNumber(); // this will call the GetIdNumber method of the student object and get the ID number of the student
Console.WriteLine($"Student ID Number: {studentIdNumber}"); // this will display the ID number of the student

//Polygon polygon = new Polygon(); // this will cause a compile-time error because Polygon is an abstract class and cannot be instantiated directly.
Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Area of the square is: {squareArea}"); // this will display the area of the square

Rectangle rectangle = new(15, 30);
var rectangleArea = rectangle.Area();
var rectanglePerimeter = rectangle.Perimeter();
var rectangleShapeName = rectangle.GetShapeName(); // this will call the GetShapeName method of the rectangle object and return "Polygon" because the Rectangle class does not override the GetShapeName method of the Polygon class
Console.WriteLine($"Area of the rectangle is: {rectangleArea}"); // this will display the area of the rectangle
Console.WriteLine($"Perimeter of the rectangle is: {rectanglePerimeter}"); // this will display the perimeter of the rectangle
Console.WriteLine($"Shape name of the rectangle is: {rectangleShapeName}"); // this will display the shape name of the rectangle

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
Console.WriteLine($"Surface area of the cuboid is: {cuboidArea}"); // this will display the surface area of the cuboid
var cuboidVolume = cuboid.Volume();
Console.WriteLine($"Volume of the cuboid is: {cuboidVolume}"); // this will display the volume of the cuboid
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Perimeter of the cuboid is: {cuboidPerimeter}"); // this will display the perimeter of the cuboid

Sphare sphere = new(7);
var sphereCircumference = sphere.Circumference();
Console.WriteLine($"{nameof(sphere)} Circumference is: {sphereCircumference}"); // this will display the circumference of the sphere
var sphereVolume = sphere.Volume();
Console.WriteLine($"{nameof(sphere)} Volume is: {sphereVolume}"); // this will display the volume of the sphere
