using POO2DiagramaDeClasses.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var group = new POO2DiagramaDeClasses.Models.Group { GroupId = 1, Name = "Turma A" };
        var student = new Student { StudentId = 1, FirstName = "Gustavo", LastName = "Silva", Group = group };
        group.AddStudent(student);

        var teacher = new Teacher { TeacherId = 1, FirstName = "Gabriela", LastName = "Oliveira" };
        var subject = new Subject { SubjectId = 1, Title = "Matemática", Teacher = teacher };
        teacher.AdicionarDisciplina(subject);

        student.Estudar();
        teacher.CriarProva(subject);
        student.FazerProva(subject, 70);
        teacher.AvaliarAluno(student, subject);

        student.FazerProva(subject, 50);
        teacher.AvaliarAluno(student, subject);
    }
}