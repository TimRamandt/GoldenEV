using GoldenEVCore.CommandLine;
using GoldenEVCore.Commands;
using System;

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
                string[] inputs = Console.ReadLine().Split(' ');
                string inputCommand = inputs[0];
                ICommand command;
                switch (inputCommand.ToUpper())
                { 
                    case "CLEAR":
                        command = new ClearCommand();
                        ExecuteOrHelp(inputs, command);
                        break;
                    case "VERSION":
                        command = new VersionCommand();
                        ExecuteOrHelp(inputs, command);
                        break;
                    case "CREATE":
                        command = new CreateCommand(inputs[1],inputs[2]);
                        ExecuteOrHelp(inputs, command);
                        break;
                    case "FETCH":
                        command = new FetchCommand();
                        ExecuteOrHelp(inputs, command);
                        break;
                    default:
                        command = new NullCommand();
                        ExecuteOrHelp(inputs, command);
                        break;
                }
            }
        }

        public void ExecuteOrHelp(string[] inputs, ICommand command)
        {
            foreach (var input in inputs)
            {
                if(input.ToUpper() == "HELP" || input.ToUpper() == "--HELP")
                {
                    command.Help();
                    return;
                }
            }
            command.Execute();
        }
    }
}
