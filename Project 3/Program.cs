using System;

namespace Project_3.Redo
{
    class Program
    {
        static void Main(string[] args)
        {

            Instructor john = new Instructor("John", "English");
            Instructor mike = new Instructor("Mike", "Math");

            john.PrintTeacherInfo();
            mike.PrintTeacherInfo();

            Student jane = new Student("Jane", 0, john);
            Student joe = new Student("Joe", 0, john);
            Student melissa = new Student("Melissa", 0, mike);
            Student matt = new Student("Matt",0, mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            jane.PrintStudentInfo();
            joe.PrintStudentInfo();
            melissa.PrintStudentInfo();
            matt.PrintStudentInfo();      
            
            System.Console.ReadKey();














        }
    }
}
