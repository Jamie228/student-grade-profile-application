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
            decimal avg;

            List<int> averg = new List<int>();

            foreach (Grade grade in gradeProfile.Where(gradeProfile => gradeProfile.yearOfStudy == year))
            {
                averg.Add(grade.grade);
            }

            avg = Convert.ToDecimal(averg.Average());

            return avg;
        }
    }
}