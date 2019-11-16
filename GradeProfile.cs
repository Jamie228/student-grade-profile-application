using System;
using System.Collections.Generic;
using System.Linq;

namespace student_grade_profile_application
{
    class GradeProfile
    {
        public void InstantiateProfile()
        {
            List<Grade> gradeProfile = new List<Grade>();
        }
        
        public void AddGrade()
        {
            throw new NotImplementedException();
        }
        public decimal Average(string studentID, int year, List<Grade> gradeProfile)
        {
            decimal avg;

            foreach (Grade grade in gradeProfile.Where(grade => grade.yearOfStudy == year && grade.studentID == studentID))
            {
                
            }
        }
    }
}