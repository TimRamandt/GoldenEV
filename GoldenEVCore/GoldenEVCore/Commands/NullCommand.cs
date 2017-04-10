using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class NullCommand : Command
    {
        public NullCommand(string[] parameters) : base(parameters) { }
        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                this.ThrowError("Command not found.");
            }
            
        }

        public override void Help()
        {
            this.ThrowError("This command doesn't exist in the Golden EV shell");
        }

    }
}
