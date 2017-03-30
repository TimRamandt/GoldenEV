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
            //this.ThrowError(string.Format("[{0}] Command not found.", DateTime.Now.ToShortTimeString()));
        }

        public void Help()
        {
            //this.ThrowError(string.Format("[{0}] This iCommand doesn't exist in the Golden EV shell", 
            //                                DateTime.Now.ToShortTimeString()));
        }

        /*public void ThrowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }*/
    }
}
