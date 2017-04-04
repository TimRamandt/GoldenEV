using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Models
{
    class Inventory
    {
        public List<Pokemon> Party { get; set; }

        public Inventory()
        {
            this.Party = new List<Pokemon>();
        }
    }
}
