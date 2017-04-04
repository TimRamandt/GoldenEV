using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class NullCommand : Command
    {
        public NullCommand(List<string> parameters) : base(parameters) { }
        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                this.ThrowError(string.Format("[{0}] Command not found.", DateTime.Now.ToShortTimeString()));
            }
            
        }

        public override void Help()
        {
            this.ThrowError(string.Format("[{0}] This command doesn't exist in the Golden EV shell", DateTime.Now.ToShortTimeString()));
        }

    }
}
