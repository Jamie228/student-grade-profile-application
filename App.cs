using System;

namespace student_grade_profile_application
{
    public class App
    {
        public string tempID;
        public void DrawMenu()
        {
            Console.WriteLine("**********");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("**********");
            Console.WriteLine();
            MainMenu();
        }

        public void MainMenu()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Option 1!");
                    break;
                
                default:
                    break;

            }

        }

        public void CreateStudent()
        {
            Console.WriteLine("Student First Name: ");
            string createFirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Student Last Name: ");
            string createLastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enrolled Course: ");
            string createCourse = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Gender: ");
            string createGender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Date of Birth (MDDMMYYYY): ");
            string createDateOfBirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Student ID: ");
            string createStudentID = Convert.ToString(Console.ReadLine());

            //tempID = createStudentID

            Student tempID = new Student(createFirstName, createLastName, createCourse, createGender, createDateOfBirth, createStudentID);
        }
    }
}