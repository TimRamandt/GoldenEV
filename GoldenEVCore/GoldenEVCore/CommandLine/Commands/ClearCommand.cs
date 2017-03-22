using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.CommandLine.Commands
{
    class ClearCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
        }
    }
}
