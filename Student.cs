using System;

namespace student_grade_profile_application
{
    class Student
    {
            protected string firstName;
            protected string lastName;
            string course;
            string gender;
            string dateOfBirth;
            string studentID;

        public Student(string firstName, string lastName, string course, string gender, string dateOfBirth, string studentID)
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
            Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}\nDate of Birth: {dateOfBirth}\nGender: {gender}\nStudent ID: {studentID}\nCourse: {course}");
        }
    }
}
