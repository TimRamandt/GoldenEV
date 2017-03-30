using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class ClearCommand : Command
    {
        public ClearCommand(List<string> parameters) : base(parameters)
        { }

        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                Console.Clear();
            }
        }

        public override void Help()
        {
            Console.WriteLine("Clears the shell.");
        }
    }
}
