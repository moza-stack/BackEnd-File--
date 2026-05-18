namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Hours { get; set; }

        // Many-To-Many
        public List<Student> Students { get; set; } = new List<Student>();
    }
}