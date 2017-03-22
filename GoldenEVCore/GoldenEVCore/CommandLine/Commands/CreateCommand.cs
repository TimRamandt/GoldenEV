using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.Models;

namespace GoldenEVCore.CommandLine.Commands
{
    class CreateCommand : ICommand
    {
        public void Execute()
        {
            //for now place it somewhere
            Pokemon pokemon = new Pokemon("Bulby", "bulbasaur");
            Console.WriteLine("Creation Succesfull");
        }
    }
}
