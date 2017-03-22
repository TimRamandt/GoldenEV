using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Models
{
    class Pokemon
    {
        public string Nickname { get; set; }
        public string OriginName { get; set; }
        public List<Stat> Stats { get; set; }

        public Pokemon(string nickname, string originName)
        {
            this.Nickname = nickname;
            this.OriginName = originName;

            this.Stats = new List<Stat>();
            InitialzeStats();
        }

        private void AddStat(string statName)
        {
            Stats.Add(new Stat(statName));
        }

        private void InitialzeStats()
        {
           AddStat("Attack");
           AddStat("Special Attack");
           AddStat("Defence");
           AddStat("Special Defence");
           AddStat("Speed");
        }
    }
}
