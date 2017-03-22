using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.Models;
using GoldenEVCore.DataLayer;

namespace GoldenEVCore.CommandLine.Commands
{
    class CreateCommand : ICommand
    {
        public void Execute()
        {
            //for now place it somewhere
            Pokemon pokemon = new Pokemon("Bulby", "bulbasaur");
            DataSource source = new DataSource();
            source.CreatePokemon(pokemon);

            Console.WriteLine("Creation Succesfull");
        }
    }
}
