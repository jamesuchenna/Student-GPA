using GPACalc.Core.Calculation;
using GPACalc.Models;
using GPACalc.Utility;

namespace GPACalc.UI
{
    public class UserInterface
    {
        /// <summary>
        /// Method prompts user for course entries
        /// </summary>
        public static void User()
        {
            Console.WriteLine("Enter the number of courses: ");
        repeat:
            string courseNum = Console.ReadLine();
            int number;
            //Validate course number
            if (!int.TryParse(courseNum, out number))
            {
                Console.WriteLine("Enter a valid number of courses");
                goto repeat;
            }
            int courseNumm = Convert.ToInt32(courseNum);

            int count = 0;
            double GPA = 0;
            //Loop through the number of courses user entered
            while (++count <= courseNumm)
            {
                Courses calculation = new Courses();
                Console.WriteLine($"Enter {count} course name and code");
            check:
                string answer = Console.ReadLine();
                //Validate course name and code
                if (string.IsNullOrWhiteSpace(answer) || answer.Length > 6)
                {
                    Console.WriteLine("Enter a valid course code");
                    goto check;
                }
                calculation.CourseName = answer.ToUpper();
                Console.WriteLine($"Enter course {count} unit");
            courseunit:
                string unit = Console.ReadLine();
                int u;
                //Validate course unit
                if (!int.TryParse(unit, out u))
                {
                    Console.WriteLine("Enter a valid course Unit number");
                    goto courseunit;
                }
                calculation.CourseUnit = Convert.ToInt32(unit);
                if (calculation.CourseUnit > 5)
                {
                    Console.WriteLine("Enter a valid course Unit number");
                    goto courseunit;
                }
                Console.WriteLine($"Enter course {count} score");
            //Validate course score
            RedoScore:
                string cScore = Console.ReadLine();
                int c;
                if (!int.TryParse(cScore, out c))
                {
                    Console.WriteLine("Enter a valid Score");
                    goto RedoScore;
                }
                calculation.Score = Convert.ToDouble(cScore);
                if (calculation.Score < 0 || calculation.Score > 100)
                {
                    Console.WriteLine("Enter a valid Score");
                    goto RedoScore;
                }
                Console.Clear();
                //Method to calculate GPA
                CourseCalc.GPA(calculation);

            }
            #region Calls methods for printing results
            PrintTable.Header();
            PrintTable.PrintResult();

            GPA = Math.Round(Convert.ToDouble(CourseCalc.TotalWeight) / CourseCalc.TotalUnit, 2, MidpointRounding.AwayFromZero);
            PrintTable.GPA(GPA);
            #endregion
        }
    }
}