using System.Drawing;
using System.Security.AccessControl;
using common_code;

namespace oop_session_1_demo

{

    internal class Program
    {
       


        static void Main(string[] args)
        {
            #region OOP
            #region Access Modifiers
            // default access modifier of class is entrenal
            //default access modifer of any class attribute is private

            //1- public
            //2- private
            //3- protected
            //4- internal
            //5- private protected
            //6- protected internal


            #region public

            //Description: Accessible from anywhere in the application.
            //Usage: When you want to make a member or type globally available
            #endregion
            #region private

            // Description: Accessible only within the containing class or struct.
            //Usage: To encapsulate functionality and prevent access from outside.
            #endregion

            #region protected

            //Description: Accessible within the containing class and by derived classes.
            //Usage: For providing controlled access to derived classes. 

            #endregion

            #region internal

            //Description: Accessible only within the same project.
            //Usage: To share functionality within an assembly without exposing it to other assemblies

            #endregion



            //Type_A A = new Type_A();
            //Type_B B = new Type_B();

            #endregion
            #endregion
            #region enum 
            //class Student
            //{
            //    public string Name;
            //    public int Id;
            //    public Gender Gender;

            //}

            //enum Gender
            //{
            //    Male,
            //    Female,
            //}

            //enum Day
            //{
            //    Sat,
            //    Sun,
            //    Mon,
            //    tues,
            //    wed,
            //    thurs,
            //    fri
            //}
            //Student S1 = new Student();
            //S1.Gender = Gender.Male;
            //S1.Name = "Mustafa";

            //Console.WriteLine(S1.Gender);

            //Day D1 = (Day)1;
            //Console.WriteLine(D1);

            //Console.WriteLine("Please enter a day");
            //bool flag = Enum.TryParse(typeof(Day), Console.ReadLine(), out object? day);
            //Console.WriteLine(flag);
            //Console.WriteLine(day);

            #region Enum with generics
            //Console.WriteLine("Please enter a day");
            //bool flag = Enum.TryParse(Console.ReadLine(),true, out Day day);
            //Console.WriteLine(flag);
            //Console.WriteLine(day);

            //================example=================
            //Day d1 = Day.fri;
            //Console.WriteLine(d1);
            //d1 = (Day)2;
            //Console.WriteLine(d1);


            #endregion

            #endregion
            #region enum Premissions
            //User U1 = new User();
            //U1.name = "Musraga";
            //U1.age = 27;
            //U1.id= 1;
            //U1.premission= (Premission)15;
            //Console.WriteLine(U1.premission);
            #region premissions with bitwise operator[XOR,AND,OR]
            //     class User
            //{
            //    public string name;
            //    public int age;
            //    public int id;
            //    public Premission premission;


            //}
            //[Flags]
            //enum Premission : byte
            //{
            //    delete = 1,
            //    update = 2,
            //    insert = 4,
            //    rename = 8,

            //}






            //User U1 = new User();
            //    //=============XOR===================
            //    //IF premission exict it remove it and if donot exict it add it
            //    U1.premission = (Premission)14;
            //U1.premission = U1.premission ^ Premission.delete;
            //Console.WriteLine(U1.premission);
            //U1.premission = U1.premission ^ Premission.delete;
            //Console.WriteLine(U1.premission);


            //=============And===================
            //check if premission exict
            //if ((U1.premission & Premission.delete)== Premission.delete){
            //    Console.WriteLine("Premission Delete is Here");
            //}
            //else
            //{
            //    U1.premission = U1.premission ^ Premission.delete;
            //    Console.WriteLine("Premission added");

            //}

            //=============OR===================
            //check if premission donot exict then add it and if exict nothing happen


            #endregion
            #endregion
            #region struct
            //struct is a value type 
            // struct donot allow inheritance 
            // result to prev innfo it dosn't allow overriding
            //====================example with unparameterized constructor=====================

            //point P1 = new point();
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);


            //====================example with parameterized constructor or user defined constructor=====================
            //point p2 = new point(2,3);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);

            //====================example with another parameterized constructor or user defined constructor=====================
            //point p2 = new point(2);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);
            #endregion
            #region oop concepts
            //1-Encapsulation
            //2-inheritance
            //3-polymorphism
            //4-abstraction
            #endregion





        }
    }
}
