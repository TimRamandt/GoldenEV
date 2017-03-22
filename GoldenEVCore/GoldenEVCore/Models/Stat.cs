using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Models
{
    class Stat
    {
        public string Name { get; set; }
        public int EV { get; set; }

        public Stat(string name)
        {
            this.Name = name;
        }
    }
}
