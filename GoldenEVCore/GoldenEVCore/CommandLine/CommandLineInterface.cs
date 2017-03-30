using GoldenEVCore.CommandLine;
using GoldenEVCore.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldenEVCore.CommandLine
{
    public class CommandLineInterface
    {
        private bool requestForHelp;
        private ICommand iCommand;
        private Command command;
        public void Intro()
        {
            Console.WriteLine("Golden EV command line.");
        }

        public void Run()
        {
            while (true)
            {
                List<string> inputs = Console.ReadLine().Split(' ').ToList();
                string inputCommand = inputs[0];
                switch (inputCommand.ToUpper())
                {
                    case "":
                        Console.Write("");
                        break;
                    case "CLEAR":
                        command = new ClearCommand(inputs);
                        command.Execute();
                        break;
                    case "HELP":
                        iCommand = new HelpCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                    case "VERSION":
                        command = new VersionCommand(inputs);
                        command.Execute();
                        break;
                    case "EXIT":
                        command = new ExitCommand(inputs);
                        command.Execute();
                        break;
                    case "CREATE":
                        iCommand = new CreateCommand(inputs);
                        iCommand.Execute();
                        break;
                    case "FETCH":
                        iCommand = new FetchCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                    default:
                        iCommand = new NullCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                }
            }
        }

        private void RequestForHelp(List<string> inputs)
        {
            foreach (var input in inputs)
            {
                if(input.ToUpper() == "HELP" || input.ToUpper() == "--HELP")
                {
                    iCommand.Help();
                    requestForHelp = true;
                    return;
                }
            }
            requestForHelp = false;
        }

        private void ExecuteCommand()
        {
            if (!requestForHelp) iCommand.Execute();
        }
    }
}
