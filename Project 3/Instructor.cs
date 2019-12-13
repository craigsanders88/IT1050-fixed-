using System;
using System.Collections.Generic;
using System.Text;

namespace Project_3.Redo
{
    class Instructor
    {
        private string Name;        
        private string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;            
        }        

        public void SetStudentGrade(Student Student, int Grade)
        {
            Student.SetGrade(Grade);
        }

        public void PrintTeacherInfo()
        {
            System.Console.WriteLine("Instructor: " + this.Name);
            System.Console.WriteLine("Course: " + this.CourseName);
            Console.WriteLine();
        }







    }
}
