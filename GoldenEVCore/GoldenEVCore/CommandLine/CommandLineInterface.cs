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
                string input = Console.ReadLine();
                string[] cleanedInput = CleanInput(input);
                string inputCommand = ExtractCommand(cleanedInput);
                string[] inputParameters = ExtractParameters(cleanedInput);

                switch (inputCommand.ToUpper())
                {
                    case "":
                        Console.Write("");
                        break;
                    case "CLEAR":
                        command = new ClearCommand(inputParameters);
                        command.Execute();
                        break;
                    case "HELP":
                        command = new HelpCommand(inputParameters);
                        command.Execute();
                        break;
                    case "VERSION":
                        command = new VersionCommand(inputParameters);
                        command.Execute();
                        break;
                    case "EXIT":
                        command = new ExitCommand(inputParameters);
                        command.Execute();
                        break;
                    case "CREATE":
                        command = new CreateCommand(inputParameters);
                        command.Execute();
                        break;
                    case "FETCH":
                        command = new FetchCommand(inputParameters);
                        command.Execute();
                        break;
                    default:
                        command = new NullCommand(inputParameters);
                        command.Execute();
                        break;
                }
            }
        }


        private string ExtractCommand(string[] cleanedInput)
        {
            return cleanedInput.FirstOrDefault();
        }

        private string[] ExtractParameters(string[] cleanedInput)
        {
            return cleanedInput.Skip(1).ToArray();
        }

        private string[] CleanInput(string input)
        {
            string[] rawInputs = input.Split('-');
            
            string[] CleanInput = new string[rawInputs.Length];
            for (int i = 0; i < rawInputs.Length; i++)
            {
                CleanInput[i] = rawInputs[i].Trim();
            }
            return CleanInput;
        }
    }
}
