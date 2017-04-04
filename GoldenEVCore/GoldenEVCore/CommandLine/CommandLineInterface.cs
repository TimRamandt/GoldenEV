using GoldenEVCore.CommandLine;
using GoldenEVCore.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldenEVCore.CommandLine
{
    public class CommandLineInterface
    {
        private Command command;
        private void Intro()
        {
            Console.Title = "Golden EV Shell";
            Console.WriteLine("Golden EV Commandline.");
            Console.WriteLine("Enter help for a command overview.");
        }

        public void Run()
        {
            Intro();   
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
                        command = new HelpCommand(inputs);
                        command.Execute();
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
                        command = new CreateCommand(inputs);
                        command.Execute();
                        break;
                    case "FETCH":
                        command = new FetchCommand(inputs);
                        command.Execute();
                        break;
                    default:
                        command = new NullCommand(inputs);
                        command.Execute();
                        break;
                }
            }
        }
    }
}
