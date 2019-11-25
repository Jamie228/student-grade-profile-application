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

            Grade grade1 = new Grade("ADD", 75, 0.7m, 2019);
            Grade grade2 = new Grade("UID", 62, 0.3m, 2019);
            Grade grade3 = new Grade("PC", 92, 1.0m, 2018);
            Grade grade4 = new Grade("DAD", 54, 0.6m, 2019);

            student1.gradeProfile.AddGrade(grade1);
            student1.gradeProfile.AddGrade(grade2);
            student2.gradeProfile.AddGrade(grade3);
            student2.gradeProfile.AddGrade(grade4);

            student1.ReportCard();
            Console.WriteLine();
            student2.ReportCard();
            Console.WriteLine();

            Console.WriteLine("Enter year of study for Student 1 Average: ");
            int userYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Student 1 Average for {userYear}: " + student1.gradeProfile.Avg(userYear));
            
            
        }
    }
}
