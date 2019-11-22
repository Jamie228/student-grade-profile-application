using System;
using System.Collections.Generic;

namespace student_grade_profile_application
{
    class Student
    {
            protected string firstName;
            protected string lastName;
            string course;
            string gender;
            string dateOfBirth;
            public string studentID;

            public GradeProfile gradeProfile = new GradeProfile();

        public Student(string firstName, string lastName, string course, string gender, string dateOfBirth, string studentID, GradeProfile gradeProfile)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.studentID = studentID;
            
        }

        public void PrintData()
        {
            Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}\nStudent ID: {studentID}\nCourse: {course}");
            Console.WriteLine();
        }


    }
}
