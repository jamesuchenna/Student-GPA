namespace GPACalc.Models
{
    /// <summary>
    /// Method creates all course properties
    /// </summary>
    public class Courses
    {
        public string CourseName { get; set; }
        public double Score { get; set; }
        public int CourseUnit { get; set; }
        public int GradeUnit { get; set; }
        public int WeightPoint { get; set; }
        public string Remark { get; set; }
        public char Grade { get; set; }
    }
}