namespace mvc_estudiantes.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}
