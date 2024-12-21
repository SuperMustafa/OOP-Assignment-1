using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_1_oop_Assignment
{
   
    internal class Program
    {
   
        static void Main(string[] args)
        {
            #region Q1
            //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.
            //        [Flags]
            //enum WeekDays : byte
            //    {
            //        Saturday = 1,
            //        Sunday = 2,
            //        Monday = 4,
            //        Tuesday = 8,
            //        Wednesday = 16,
            //        Thursday = 32,
            //        Friday = 64,
            //    }
            //WeekDays Days = (WeekDays)127;

            //Console.WriteLine(Days);
            #endregion
            #region Q2
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects
            //and populate it with data.Then, write a C# program to display the details of all the persons in the array.

            //     struct Person
            //{
            //    public string name;
            //    public int age;

            //    public Person(string name, int age)
            //    {
            //        this.name = name;
            //        this.age = age;
            //    }
            //}
            //Person[] persons = new Person[3];

            //    // Populate the array with data
            //    persons[0] = new Person { name = "Mustafa", age = 25 };
            //    persons[1] = new Person { name = "Mohamed", age = 30 };
            //    persons[2] = new Person { name = "Nada", age = 35 };

            //    foreach (var person in persons)
            //    {
            //        Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            //    }
            #endregion
            #region Q3
            //Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month
            //    range for that season. Note range for seasons ( spring march to may , summer june to august ,
            //    autumn September to November , winter December to February)

            //      enum Seasons
            //{
            //    Winter,
            //    Spring,
            //    Summer,
            //    Autumn,
            //}
            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");


            //if (Enum.TryParse(Console.ReadLine(), true, out Seasons season))
            //{
            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Seasons.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion
            #region Q4
            //Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable
        //    [Flags]
        //enum Premissions : byte
        //{
        //    Read = 1,
        //    Write = 2,
        //    Delete = 4,
        //    Execute = 8,
        //}

        //Premissions premissions = (Premissions)15;
        //    Console.WriteLine(premissions);




        #endregion





    }
}
}
