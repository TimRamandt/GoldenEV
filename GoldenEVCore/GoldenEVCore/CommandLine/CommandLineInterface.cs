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
        private ICommand command;
        private Command testCommand;
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
                        command = new ClearCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                    case "HELP":
                        command = new HelpCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                    case "VERSION":
                        /*command = new VersionCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();*/
                        testCommand = new VersionCommand(inputs);
                        testCommand.Execute();
                        break;
                    case "EXIT":
                        command = new ExitCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                    case "CREATE":
                        command = new CreateCommand(inputs);
                        command.Execute();
                        break;
                    case "FETCH":
                        command = new FetchCommand();
                        RequestForHelp(inputs);
                        ExecuteCommand();
                        break;
                    default:
                        command = new NullCommand();
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
                    command.Help();
                    requestForHelp = true;
                    return;
                }
            }
            requestForHelp = false;
        }

        private void ExecuteCommand()
        {
            if (!requestForHelp) command.Execute();
        }
    }
}
