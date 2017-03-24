using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class NullCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Command not found.");
        }

        public void Help()
        {
            Console.WriteLine("This command doesn't excist. Check if you typed the command correctly.");
        }
    }
}
