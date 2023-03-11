using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeNum = double.Parse(Console.ReadLine());
            string gradeText = getGradeText(gradeNum);
            Console.WriteLine(gradeText);
        }

        private static string getGradeText(double gradeNum)
        {
            if (gradeNum < 3)
            {
                return "Fail";
            }
            else if (gradeNum < 3.50) {
                return "Poor";
            }
            else if (gradeNum < 4.50)
            {
                return "Good";
            }
            else if (gradeNum < 5.50)
            {
                return "Very good";
            }
            else
            {
                return "Excellent";
            }
        }
    }
}