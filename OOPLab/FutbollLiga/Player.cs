using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollLiga
{
    class Player
    {
        private string firstName;
        private string lastName;
        private DateTime bornDate;
        private decimal salary;
        private Team team;
        private const int MinimumAllowedYear = 1980;

        public Player(string firstName, string lastName, DateTime bornDate, decimal salary, string team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BornDate = bornDate;
            this.Salary = salary;
            this.Team = team;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Firstname should be at least 3 char long.");
                }
                this.firstName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Firstname should be at least 3 char long.");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negativ");
                }
                this.salary = value;
            }
        }

        public DateTime BornDate
        {
            get
            {
                return this.bornDate;
            }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of Birthday cannot be earlier that " + MinimumAllowedYear);
                }
                this.bornDate = value;
            }
        }

        public Team Team { get; set; }

    }
}
