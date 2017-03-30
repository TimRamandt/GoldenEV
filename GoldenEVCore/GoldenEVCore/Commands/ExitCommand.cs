using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class ExitCommand : Command
    {
        public ExitCommand(List<string> parameters) : base(parameters)
        { }

        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                Environment.Exit(0);
            }
            
        }

        public override void Help()
        {
            Console.WriteLine("Exit the shell cleanly.");
        }
    }
}
