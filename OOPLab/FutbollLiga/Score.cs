using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollLiga
{
    class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }
        public int AwayTeamGoals
        {
            get
            {
                return this.awayTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negativ");
                }
                this.awayTeamGoals = value;
            } 
        }
        public int HomeTeamGoals
        {
            get
            {
                return this.homeTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negativ");
                }
                this.homeTeamGoals = value;
            } 
        }

    }
}
