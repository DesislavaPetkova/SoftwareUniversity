using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        private ICollection<Player> players;
        private ICollection<Match> homeMatches;
        private ICollection<Match> awayMatches;

        private ICollection<Vote> votes; 

        public Team()
        {
            this.Players = new HashSet<Player>();
            this.HomeMatches = new HashSet<Match>();
            this.AwayMatches = new HashSet<Match>();
            this.Votes = new HashSet<Vote>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string NickName { get; set; }
        [Url]
        public string WebSite { get; set; }

        public string DateFounded { get; set; }

        public virtual ICollection<Player> Players
        {
            get
            {
                return this.players;
            }
            set
            {
                this.players = value;
            }
        }

        public virtual ICollection<Match> HomeMatches
        {
            get
            {
                return this.homeMatches;
            }
            set
            {
                this.homeMatches = value;
            }
        }
        public virtual ICollection<Match> AwayMatches
        {
            get
            {
                return this.awayMatches;
            }
            set
            {
                this.awayMatches = value;
            }
        }
        public virtual ICollection<Vote> Votes
        {
            get
            {
                return this.votes;
            }
            set
            {
                this.votes = value;
            }
        }

    }
}
