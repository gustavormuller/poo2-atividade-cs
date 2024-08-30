

namespace POO2DiagramaDeClasses.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public required string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
                student.Group = this;
            }
        }

        public void RemoveStudent(Student student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
                student.Group = null;
            }
        }
    }
}
