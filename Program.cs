﻿using System;
using System.Collections.Generic;

namespace student_grade_profile_application
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student1 = new Student("John","Williams","Computing and Information Systems", "Male", "22082000", "1804492");

            Student student2 = new Student("Sarah", "Smith", "Computing and Information Systems", "Female", "06121999", "1807794");

            List <Student> students = new List<Student>();

            students.Add(student1);
            students.Add(student2);

            foreach(Student student in students)
            {
              student.PrintData();
            }



        }

    }
}
