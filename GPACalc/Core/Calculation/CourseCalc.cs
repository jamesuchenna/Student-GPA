using GPACalc.Models;
using GPACalc.Data;

namespace GPACalc.Core.Calculation
{
    public class CourseCalc
    {
        public static int TotalWeight = 0;
        public static int TotalUnit = 0;
        public static int TotalPassed = 0;

        /// <summary>
        /// Method calculates the student's GPA
        /// </summary>
        /// <param name="calculation"></param>
        public static void GPA(Courses calculation)
        {
            if (calculation.Score >= 40)
                TotalPassed += calculation.CourseUnit;

            if (calculation.Score >= 70)
            {
                calculation.Grade = 'A';
                calculation.Remark = "Exellent";
                calculation.GradeUnit = 5;
            }
            else if (calculation.Score >= 60)
            {
                calculation.Grade = 'B';
                calculation.Remark = "Very Good";
                calculation.GradeUnit = 4;
            }
            else if (calculation.Score >= 50)
            {
                calculation.Grade = 'C';
                calculation.Remark = "Good";
                calculation.GradeUnit = 3;

            }
            else if (calculation.Score >= 45 && calculation.Score <= 49)
            {
                calculation.Grade = 'D';
                calculation.Remark = "Fair";
                calculation.GradeUnit = 2;
            }
            else if (calculation.Score >= 40 && calculation.Score <= 44)
            {
                calculation.Grade = 'E';
                calculation.Remark = "Pass";
                calculation.GradeUnit = 1;
            }
            else if (calculation.Score >= 0 && calculation.Score <= 39)
            {
                calculation.Grade = 'F';
                calculation.Remark = "Fail";
                calculation.GradeUnit = 0;
            }

            calculation.WeightPoint = calculation.CourseUnit * calculation.GradeUnit;

            DataStore.courseList.Add(calculation);

            TotalWeight += calculation.WeightPoint;
            TotalUnit += calculation.CourseUnit;
        }
    }
}