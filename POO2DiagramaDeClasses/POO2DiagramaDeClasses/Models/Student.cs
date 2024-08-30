using System;
using System.Collections.Generic;
using System.Linq;


namespace POO2DiagramaDeClasses.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required Group Group { get; set; }
        public List<Mark> Marks { get; set; } = new List<Mark>();

        public void FazerProva(Subject subject, int score)
        {
            var mark = new Mark { MarkId = Marks.Count + 1, Date = DateTime.Now, Score = score, Student = this, Subject = subject };
            Marks.Add(mark);
        }

        public void Estudar()
        {
            Console.WriteLine($"{FirstName} {LastName} está estudando.");
        }

        public void Conversar()
        {
            Console.WriteLine($"{FirstName} {LastName} está conversando.");
        }

        public double CalcularMedia()
        {
            if (Marks.Count == 0) return 0;

            double total = 0;
            foreach (var mark in Marks)
            {
                total += mark.Score;
            }
            return total / Marks.Count;
        }
    }
}
