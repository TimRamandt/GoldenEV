using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.Models;
using GoldenEVCore.DataLayer;

namespace GoldenEVCore.Commands
{
    class CreateCommand : ICommand
    {
        public string Name { get; set; }
        public string OriginalName { get; set; }
        private bool validInput = true;
        private bool isHelpRequest = false;

        public CreateCommand(List<string> inputs)
        {
            parameterCheck(inputs, 2);
            if (validInput)
            {
                  this.Name = inputs[1];
                  this.OriginalName = inputs[2];
            }
        }

        private void parameterCheck(List<string> inputs, int requiredParameters)
        {
            if(inputs.Count < requiredParameters + 1)
            {                
                validInput = false;
            }

            for (int i = 1; i < inputs.Count; i++)
            {
                parameterSingleCheck(inputs[i]);
            }

            if (!isHelpRequest && inputs.Count < requiredParameters + 1)
            {
                this.ThrowError(String.Format("[{0}] this command requireds {1} parameters. Type Create help for more info.",
                                                DateTime.Now.ToShortTimeString(), requiredParameters));
            }

            
        }

        private void parameterSingleCheck(string input)
        {
            if (input == null || input == "")
            {
                this.ThrowError(String.Format("[{0}] the parameter {1} is not valid. Type Create help for more info.", 
                                                DateTime.Now.ToShortTimeString(), input));
                validInput = false;
            }

            if(input.ToUpper() == "HELP")
            {
                this.Help();
                validInput = false;
                isHelpRequest = true;
            }
        }

        public void Execute()
        {
            if (validInput)
            {
                Pokemon pokemon = new Pokemon(Name, OriginalName);
                DataSource source = new DataSource();
                //source.CreatePokemon(pokemon);
                Console.WriteLine("[{0}] pokémon creation successful.", DateTime.Now.ToShortTimeString());
            }
            
        }

        public void Help()
        {
            Console.WriteLine("Creates a new pokémon, with fresh EV stats");
            Console.WriteLine("Syntax: Create <string:Name> <string:OriginalName>");
        }

        public void ThrowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
