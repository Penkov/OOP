using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollLiga
{
    class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();


        private static IEnumerable<Team> Teams
        {
            get
            {
                return teams;
            }
        }
        private static IEnumerable<Match> Matches
        {
            get
            {
                return matches;
            }
        }



    }
}
