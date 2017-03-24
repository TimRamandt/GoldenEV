using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class ClearCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
        }

        public void Help()
        {
            Console.WriteLine("Clears the commandline ");
        }
    }
}
