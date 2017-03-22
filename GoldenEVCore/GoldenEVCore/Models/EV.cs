using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Models
{
    class EV
    {
        public int Value { get; set; }

        public void addEV(int EVValue)
        {
            Value += EVValue;
        }

        public void correctEV(int EVValue)
        {
            if (Value - EVValue >= 0)
                Value = Value - EVValue;
        }
    }
}
