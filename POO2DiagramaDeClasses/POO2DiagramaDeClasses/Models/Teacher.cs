

namespace POO2DiagramaDeClasses.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public void CriarProva(Subject subject)
        {
            Console.WriteLine($"Prova criada para a disciplina {subject.Title} por {FirstName} {LastName}.");
        }

        public void AvaliarAluno(Student student, Subject subject)
        {
            subject.AvaliarAluno(student);
        }

        public void AdicionarDisciplina(Subject subject)
        {
            if (!Subjects.Contains(subject))
            {
                Subjects.Add(subject);
                subject.Teacher = this;
            }
        }

        public void RemoverDisciplina(Subject subject)
        {
            if (Subjects.Contains(subject))
            {
                Subjects.Remove(subject);
                subject.Teacher = null;
            }
        }
    }
}
