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

        public Pokemon(string nickname, string originName)
        {
            this.Nickname = nickname;
            this.OriginName = originName;
        }
    }
}
