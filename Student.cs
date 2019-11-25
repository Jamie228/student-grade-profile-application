using System;
using System.Collections.Generic;

namespace student_grade_profile_application
{
    class Student
    {
            protected string firstName;
            protected string lastName;
            protected string course;
            protected string gender;
            protected string dateOfBirth;
            public string studentID;

            public GradeProfile gradeProfile = new GradeProfile();

        public Student(string firstName, string lastName, string course, string gender, string dateOfBirth, string studentID, GradeProfile gradeProfile) //Student Constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.studentID = studentID;
            
        }

        public void ReportCard()    //Prints structure for student Report Card
        {
            Console.WriteLine();
            Console.WriteLine("*** REPORT ***");
            Console.WriteLine($"Name: {lastName}, {firstName}");
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine();
            Console.WriteLine("--- GRADES ---");
            gradeProfile.ReportInfo();
        }


    }
}
