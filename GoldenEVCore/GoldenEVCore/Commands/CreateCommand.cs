using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.Models;
using GoldenEVCore.DataLayer;

namespace GoldenEVCore.Commands
{
    class CreateCommand : Command
    {
        public string Name { get; set; }
        public string OriginalName { get; set; }
        private bool validInput = true;
        private bool isHelpRequest = false;

        public CreateCommand(string[] parameters) : base(parameters) {
            if (!IsHelpRequested)
            {
                ParameterCheck(parameters, 2);
                if (validInput)
                {
                    this.Name = parameters[1];
                    this.OriginalName = parameters[2];
                }
            }
            
        }

        private void ParameterCheck(string[] inputs, int requiredParameters)
        {
            if(inputs.Length < requiredParameters + 1)
            {                
                validInput = false;
            }

            for (int i = 1; i < inputs.Length; i++)
            {
                parameterSingleCheck(inputs[i]);
            }

            if (!isHelpRequest && inputs.Length < requiredParameters + 1)
            {
                this.ThrowError($"this command requires {requiredParameters} parameters. Type Create help for more info.");
            }
        }

        private void parameterSingleCheck(string input)
        {
            if (input == null || input == "")
            {
                this.ThrowError($"the parameter {input} is not valid. Type Create help for more info.");
                validInput = false;
            }
        }

        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                if (validInput)
                {
                    Pokemon pokemon = new Pokemon(Name, OriginalName);
                    DataSource source = new DataSource();
                    //source.CreatePokemon(pokemon);
                    Console.WriteLine("[{0}] pokémon creation successful.", DateTime.Now.ToShortTimeString());
                }                
            }
        }

        public override void Help()
        {
            Console.WriteLine("Creates a new pokémon, with fresh EV stats");
            Console.WriteLine("Syntax: Create <string:Name> <string:OriginalName>");
        }
        
    }
}
