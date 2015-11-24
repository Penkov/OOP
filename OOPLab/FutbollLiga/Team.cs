using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollLiga
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.players;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("This name is short");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Nickname 
        {
            get
            {
                return this.nickname;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("This nickname is short");
                }
                else
                {
                    this.nickname = value;
                }
            }
        }

        public DateTime DateFounded { get; set; }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team.");
            }
            this.players.Add(player);
        }
        
        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                                        p.LastName == player.LastName);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("This team: {0}, nickname: {1}, date founded: {2}", this.Name,this.Nickname, this.DateFounded));
            return sb.ToString();
        }

    }
}
