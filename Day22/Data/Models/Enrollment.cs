namespace Day22.Data.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
