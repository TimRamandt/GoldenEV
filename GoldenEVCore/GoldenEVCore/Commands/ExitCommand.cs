using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }

        public void Help()
        {
            Console.WriteLine("Exit the shell cleanly.");
        }

        public void ThrowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
