

namespace POO2DiagramaDeClasses.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public required Student Student { get; set; }
        public required Subject Subject { get; set; }

        public bool IsPassingGrade()
        {
            return Score >= 60;
        }
    }
}
