using System;

namespace student_grade_profile_application
{
    class Grade
    {
        string assignment;
        string module;
        int grade;
        decimal weight;
        public Grade(string assignment, string module, int grade, decimal weight)
        {
            this.assignment = assignment;
            this.module = module;
            this.grade = grade;
            this.weight = weight;

        }
    }
}