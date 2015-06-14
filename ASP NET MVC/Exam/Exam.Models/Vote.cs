namespace Exam.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public int Value { get; set; }

        public string UserId { get; set; }  

        public virtual User User { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }  
    }
}
