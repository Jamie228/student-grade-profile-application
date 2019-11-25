using System;
using System.Collections.Generic;
using System.Linq;

namespace student_grade_profile_application
{
    class GradeProfile
    {   
        List<Grade> gradeProfile = new List<Grade>();
        public void AddGrade(Grade grade)
        {
            gradeProfile.Add(grade);
        }

        public void DisplayGrades()
        {
            foreach (Grade grade in gradeProfile)
            {
                Console.WriteLine(grade.grade);
            }
        }
        public decimal Avg(int year)
        {

            List<int> averg = new List<int>(); //Creates list

            foreach (Grade grade in gradeProfile.Where(gradeProfile => gradeProfile.yearOfStudy == year)) //Checks all values in gradeProfile where the year of study equals the passed in value
            {
                averg.Add(grade.grade); //Adds these to the list
            }

            decimal avg = Convert.ToDecimal(averg.Average()); //Calculates average of the list

            return avg; //Returns the average
        }

        public void ReportInfo()
        {
            foreach (Grade grade in gradeProfile)
            {
                Console.WriteLine($"Module: {grade.module}");
                Console.WriteLine($"Year of Study: {grade.yearOfStudy}");
                Console.WriteLine($"Grade: {grade.grade}");
                Console.WriteLine();
            }
        }
    }
}