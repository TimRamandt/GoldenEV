using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class HelpCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The full commandList with a brief description:");
            Console.WriteLine("Clear - Clears the commandline.");
            Console.WriteLine("Create - Creates a new pokemon, with fresh EV stats.");
            Console.WriteLine("Exit - Exit the shell application nicely.");
            Console.WriteLine("Fetch - Fetches the user data file.");
            Console.WriteLine("Version - Displays the current version of the application.");

            Console.WriteLine("");
            Console.WriteLine("You can get more information of a command by typing help next to it.");
        }

        public void Help()
        {
            this.Execute();
        }

        public void ThrowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
