namespace StudentManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // One-To-Many
        public List<Student> Students { get; set; } = new List<Student>();
    }
}