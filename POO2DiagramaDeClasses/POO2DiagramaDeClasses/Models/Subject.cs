

namespace POO2DiagramaDeClasses.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public required string Title { get; set; }
        public required Teacher Teacher { get; set; }

        protected void AprovarAluno(Student student)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} foi aprovado em {Title}.");
        }

        protected void ReprovarAluno(Student student)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} foi reprovado em {Title}.");
        }

        public void AvaliarAluno(Student student)
        {
            double media = student.CalcularMedia();
            if (media >= 60)
            {
                AprovarAluno(student);
            }
            else
            {
                ReprovarAluno(student);
            }
        }
    }
}
