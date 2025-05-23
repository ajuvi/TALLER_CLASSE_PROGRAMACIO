using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Pattern
{
    public class Team
    {
        private string avb;
        private string name;
        private int budget;
        private string logoLink;
        public Team() { }
        public Team(string avb, string name, int budget, string logoLink)
        {
            this.Avb = avb;
            this.Name = name;
            this.Budget = budget;
            this.LogoLink = logoLink;
        }

        public string Avb { get => avb; set => avb = value; }
        public string Name { get => name; set => name = value; }
        public int Budget { get => budget; set => budget = value; }
        public string LogoLink { get => logoLink; set => logoLink = value; }

        public int CompareTo(Team? other)
        {
            if (other == null) return 1;
            else return this.Budget - other.Budget;

        }

        public override bool Equals(object? obj)
        {
            return obj is Team team &&
                   Avb == team.Avb;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Avb);
        }
    }
}
