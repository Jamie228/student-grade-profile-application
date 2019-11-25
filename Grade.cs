using System;

namespace student_grade_profile_application
{
    class Grade
    {
        public string module;
        public int grade;
        public int yearOfStudy;
        decimal weight;

        public Grade(string module, int grade, decimal weight, int yearOfStudy) //Grade constructor
        {
            this.module = module;
            this.grade = grade;
            this.weight = weight;
            this.yearOfStudy = yearOfStudy;
        }
    }
}