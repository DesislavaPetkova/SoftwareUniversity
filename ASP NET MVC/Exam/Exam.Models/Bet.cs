namespace Exam.Models
{
    public class Bet
    {
        public int Id { get; set; }

        public double HomeBet { get; set; }
        public double AwayBet { get; set; }

        public string UserId { get; set; }
            
        public virtual User User { get; set; }

        public int MatchId { get; set; }

        public virtual Match Match { get; set; }
    }
}
