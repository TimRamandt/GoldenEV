using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.Commands;

namespace GoldenEVCore.Commands
{
    class FetchCommand : Command
    {

        public FetchCommand(List<string> parameters) : base(parameters) { }
        //check if file exists

        //if file not exists, create one
        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                throw new NotImplementedException();
            }
            
        }

        public override void Help()
        {
            Console.WriteLine("Fetches the XML document that saves the data. If no file is found, it automatically create a new one.");
        }

        public void ThrowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
