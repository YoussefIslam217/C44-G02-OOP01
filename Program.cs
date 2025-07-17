using System;
using System.ComponentModel;

namespace AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //2- Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Youssef",21);
            //persons[1] = new Person("Yassin", 17);
            //persons[2] = new Person("Mohamed", 18);
            //foreach(Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            //3- Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.Write("Please enter a season: ");
            //Season seasonName;
            //while (!Enum.TryParse(Console.ReadLine().ToLower(), out seasonName))
            //{
            //    Console.Write("Invalid input. Please enter a season name correctly: ");
            //}
            //switch (seasonName)
            //{
            //    case Season.spring:
            //        Console.WriteLine("spring: march to may");
            //        break;
            //    case Season.summer:
            //        Console.WriteLine("summer: june to august ");
            //        break;
            //    case Season.autumn:
            //        Console.WriteLine("autumn: September to November");
            //        break;
            //    case Season.winter:
            //        Console.WriteLine("winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season");
            //        break;
            //}

            //4 - Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //User user01 = new User();
            ////add a permission and check if specific Permission is existed or not using | ==> (or)
            //user01.Permissions = (Permissions)10;
            //user01.Permissions = user01.Permissions | Permissions.Delete;
            //Console.WriteLine(user01.Permissions);
            ////Remove a permission
            //user01.Permissions ^= Permissions.Delete;
            //Console.WriteLine(user01.Permissions);

            //5- Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Please enter a color name: ");
            //Colors colorName;
            //Enum.TryParse(Console.ReadLine().ToLower(), out colorName);
            //if (colorName == Colors.red || colorName == Colors.green || colorName == Colors.blue)
            //{
            //    Console.WriteLine("This is a Primary color");
            //}
            //else
            //{
            //    Console.WriteLine("This is not a Primary color");
            //}

            //6- Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point[] points = new Point[2];
            //double x, y;
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.Write($"Please enter x-coordinate for the point {i+1}: ");
            //    while (!double.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.Write("Invalid input. Please enter the value of x-coordinate correctly: ");
            //    }
            //    Console.Write($"Please enter y-coordinate for the point {i + 1}: ");
            //    while (!double.TryParse(Console.ReadLine(), out y))
            //    {
            //        Console.Write("Invalid input. Please enter the value of x-coordinate correctly: ");
            //    }
            //    points[i]= new Point(x, y);
            //}
            //double distance = Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
            //Console.WriteLine($"Distance between two points: {distance}");


            //7- Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];
            //string PersonName;
            //int PersonAge;
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.Write($"Please enter the name of the Person {i+1}: ");
            //    PersonName =Console.ReadLine();
            //    Console.Write($"Please enter the age of the Person {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out PersonAge))
            //    {
            //        Console.Write("Invalid input. Please enter the age of the person correctly: ");
            //    }
            //    persons[i] = new Person(PersonName,PersonAge);
            //}
            //Person oldestPerson = persons[0];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if(persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}
            //Console.WriteLine("The data of the oldest person: ");
            //Console.WriteLine(oldestPerson);
        }
    }
}
