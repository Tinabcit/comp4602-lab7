namespace BlazorStudents.Models
{
    public class Student
    {
        public int Id { get; set; } // Ensure ID is properly assigned
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string School { get; set; }

        public static IQueryable<Student> GetStudents()
        {
            // Ensure ID increments correctly
            List<Student> students = new();
            for (int i = 1; i <= 10; i++) // Generate sample students
            {
                students.Add(new Student
                {
                    Id = i,
                    FirstName = $"Student{i}",
                    LastName = $"Last{i}",
                    School = "Computing"
                });
            }

            return students.AsQueryable();
        }
    }
}
