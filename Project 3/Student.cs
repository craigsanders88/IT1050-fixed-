using System;
using System.Collections.Generic;
using System.Text;

namespace Project_3.Redo
{
    class Student
    {
        private string name;        
        private int grade;
        private Instructor teacher;      

        public Student(string Name, int Grade, Instructor teacher)
        {
            name = Name;
            grade = Grade; 
            teacher = teacher;            
        }
        
        public void SetGrade(int Grade)
        {
            this.grade = Grade;            
        }

        public void PrintStudentInfo()
        {
            System.Console.WriteLine("Student Name:" + this.name);
            System.Console.WriteLine("Instructor: " + this.teacher);
            System.Console.WriteLine(" Grade : " + this.grade); 
        
        }

    }
}
