using System;
using System.Collections.Generic;

namespace student_grade_profile_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John","Williams","Computing and Information Systems", "Male", "22082000", "1804492");
            student1.PrintData();

            Student student2 = new Student("Sarah", "Smith", "Computing and Information Systems", "Female", "06121999", "1807794");
            student2.PrintData();

            List <Student> students = new List<Student>();

        }

    }
}
