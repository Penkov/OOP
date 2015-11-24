using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollLiga
{
    class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;
        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }
        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public Score Score { get; set; }

        public int Id { get; set; }

        public Team GetWinner()
        {
            if (this.IsDrow())
            {
                return null;
            }
            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }
        private bool IsDrow()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }
    }
}
