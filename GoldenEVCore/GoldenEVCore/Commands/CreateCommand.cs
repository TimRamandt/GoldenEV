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
                this.ThrowError(String.Format("[{0}] Invalid parameters. Type Create help for more info.",
                                                  DateTime.Now.ToShortTimeString()));
                validInput = false;
                return;
            }

            for (int i = 1; i < inputs.Count; i++)
            {
                parameterSingleCheck(inputs[i]);
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
        }

        public void Execute()
        {
            if (validInput)
            {
                Pokemon pokemon = new Pokemon(Name, OriginalName);
                DataSource source = new DataSource();
                //source.CreatePokemon(pokemon);
                Console.WriteLine("[{0}] creation succesfull", DateTime.Now.ToShortTimeString());
            }
            
        }

        public void Help()
        {
            Console.WriteLine("Creates a new pokemon, with fresh EV stats");
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
