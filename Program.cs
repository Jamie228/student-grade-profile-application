using System;
using System.Collections.Generic;

namespace student_grade_profile_application
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeProfile gradeProfile = new GradeProfile();
            
            Student student1 = new Student("John","Williams","Computing and Information Systems", "Male", "22082000", "1804492", gradeProfile);

            Student student2 = new Student("Sarah", "Smith", "Computing and Information Systems", "Female", "06121999", "1807794", gradeProfile);

            List <Student> students = new List<Student>();

            students.Add(student1);
            students.Add(student2);

            Grade gradeTest = new Grade("010", "ADD", 75, 0.7m, 2019);
            Grade gradeTest2 = new Grade("011", "ADD", 62, 0.3m, 2019);

            student1.gradeProfile.AddGrade(gradeTest);
            student1.gradeProfile.AddGrade(gradeTest2);
            student2.gradeProfile.AddGrade(gradeTest);

            foreach(Student student in students)
            {
              student.PrintData();
            }

            student1.gradeProfile.DisplayGrades();
            Console.WriteLine();
            student2.gradeProfile.DisplayGrades();

            Console.WriteLine(student1.gradeProfile.Avg(2019));
        }
    }
}
