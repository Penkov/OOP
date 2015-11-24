using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollLiga
{
    class LeagueManager
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddPlayerToTeam":
                    string firstName = inputArgs[1];
                    string lastName = inputArgs[2];
                    DateTime bornDate = DateTime.Parse(inputArgs[3]);
                    decimal salary = decimal.Parse(inputArgs[4]);
                    string teamName = inputArgs[5];

                    AddPlayerToTeam(firstName, lastName, bornDate, salary, teamName);
                    break;
                case "AddMatch":
                    string homeTeam = inputArgs[2];
                    string aweyTeam = inputArgs[3];

                    break;


            }
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime bornDate, decimal salary, string teamName)
        {
            var team = teams.FirstOrDefault(t => t.Name == teamName);
            var player = new Player(firstName, lastName, bornDate, salary, teamName);
        }
        private static void AddMatch(Team teamFirst, Team teamSecond, Score score, int id)
        {
            
        }

        private static void AddTeam(string name, string nickname, DateTime dateFounded)
        {
            if (!teams.Any(t => t.Name == name ))
            {
                var team = new Team(name, nickname, dateFounded);
                teams.Add(team);
            }
            throw new ArgumentException("This team is created");
            
        }
        public static void Main()
        {

        }
    }
}
