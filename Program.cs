using System;

namespace student_grade_profile_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John","Williams","Computing and Information Systems", "Male", "22082000", "1804492");
            student1.PrintData();
        }

    }
}
