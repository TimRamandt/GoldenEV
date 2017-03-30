using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class Command
    {
        public bool IsHelpRequested { get; private set; }
        public List<string> Parameters { get; set; }
        public Command(List<string> parameters)
        {
            this.Parameters = parameters;
            CheckIsHelpRequested(parameters);
        }

        public void CheckIsHelpRequested(List<string> parameters)
        {
            foreach (var parameter in parameters)
            {
                if (parameter.ToUpper() == "HELP" || parameter.ToUpper() == "--HELP")
                {
                    IsHelpRequested = true;
                    Help();
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
