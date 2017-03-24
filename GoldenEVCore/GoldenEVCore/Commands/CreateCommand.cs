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
        

        public CreateCommand(string name, string originalName)
        {
            this.Name = name;
            this.OriginalName = OriginalName;
        }

        public void Execute()
        {
            
            Pokemon pokemon = new Pokemon(Name, OriginalName);
            DataSource source = new DataSource();
            //source.CreatePokemon(pokemon);

            Console.WriteLine("[{0}] Creation Succesfull", DateTime.Now.TimeOfDay);
        }

        public void Help()
        {
            Console.WriteLine("Creates a new pokemon, with fresh EV stats");
            Console.WriteLine("Syntax: Create <string:Name> <string:OriginalName>");
        }
    }
}
