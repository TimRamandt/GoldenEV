using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.CommandLine.Commands;

namespace GoldenEVCore.CommandLine
{
    public class CommandLineInterface
    {
        public void Intro()
        {
            Console.WriteLine("Golden EV command line.");
        }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                ICommand Command;
                switch (input.ToUpper())
                { 
                    case "CLEAR":
                        Command = new ClearCommand();
                        Command.Execute();
                        break;
                    case "VERSION":
                        Command = new VersionCommand();
                        Command.Execute();
                        break;
                    case "CREATE":
                        Command = new CreateCommand();
                        Command.Execute();
                        break;
                    default:
                        Command = new NullCommand();
                        Command.Execute();
                        break;
                }
            }
        }
    }
}
