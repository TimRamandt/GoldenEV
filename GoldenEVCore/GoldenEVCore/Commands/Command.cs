using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class Command
    {
        public bool isHelpRequested { get; set; }
        public List<string> Inputs { get; set; }
        public Command(List<string> inputs)
        {
            this.Inputs = inputs;
        }

        public void checkIsHelpRequested(List<string> inputs)
        {
            foreach (var input in inputs)
            {
                if (input.ToUpper() == "HELP" || input.ToUpper() == "--HELP")
                {
                    isHelpRequested = true;
                }
            }
        }

        public virtual void Execute() { }

        public virtual void Help() { }

        public void ThrowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
