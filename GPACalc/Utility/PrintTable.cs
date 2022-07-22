using GPACalc.Models;
using GPACalc.Data;
using GPACalc.Core.Calculation;

namespace GPACalc.Utility
{
    /// <summary>
    /// Method Displays GPA calculator
    /// </summary>
    public static class PrintTable
    {
        #region Print Table methods
        public static void Header()
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine($"|{"Name",-10} |{"Unit",-10} |{"Grade",-10} |{"Grade Unit",-10} |{"Weight Pt",-10} |{"Remark",-10}|");
            Console.WriteLine("========================================================================");
        }

        public static void PrintResult()
        {
            foreach (Courses calculation in DataStore.courseList)
            {
                Console.WriteLine($"|{calculation.CourseName,-10} |{calculation.CourseUnit,-10} |{calculation.Grade,-10} |{calculation.GradeUnit,-10} |{calculation.WeightPoint,-10} |{calculation.Remark,-10}|");
            }
            Console.WriteLine("========================================================================");

        }


        public static void GPA(double GPA)
        {
            Console.WriteLine($"Total Registered course unit is {CourseCalc.TotalUnit}");
            Console.WriteLine($"Total passed is {CourseCalc.TotalPassed}");
            Console.WriteLine($"Total weight point is {CourseCalc.TotalWeight}");
            Console.WriteLine($"Your GPA = {GPA}");
            Console.WriteLine();
            if (GPA >= 4.5) Console.WriteLine("You are a First class student");
        }
        #endregion
    }
}