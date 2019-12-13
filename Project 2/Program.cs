using System;

namespace The_Two_Couples
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult p1 = new Adult();
            p1.AskUserForNameAndAge();       //Revist Spouse code, line 41  under class. 
            p1.CreateSpouseIfMarried();      //                       
            Adult p2 = new Adult();
            p2.AskUserForNameAndAge();
            p2.CreateSpouseIfMarried();

            System.Console.WriteLine("Please register your information below: ");        //GitHub, IT1050, Section 2, Example4_, Orders.cs, Programs.cs, Questions.cs
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();

            Adult.AverageAge();











        }
    }
}

