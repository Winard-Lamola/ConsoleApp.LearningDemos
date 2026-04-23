using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public partial class Person
    {
        // This is a partial class, it can be split into multiple files and the compiler will combine them into one class
        // This is useful for organizing code and separating concerns
        public Person(string firstName, string lastName, DateOnly dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //public int CalculateAge()
        //{
        //    var today = DateOnly.FromDateTime(DateTime.Today);
        //    var age = today.Year - DateOfBirth.Year;
        //    if (today < DateOfBirth.AddYears(age))
        //    {
        //        age--;
        //    }
        //    return age;
        //}

        public int GetAge()
        {
            var age = DateTime.Now.Year - DateOfBirth.Year;
            return age;
        }

        public string GetAge(int year)
        {
            var age = year - DateOfBirth.Year;
            return $"Age: {age}";
        }

    }
}
