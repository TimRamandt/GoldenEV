﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.Commands;

namespace GoldenEVCore.Commands
{
    class FetchCommand : ICommand
    {
        //check if file exists

        //if file not exists, create one
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Help()
        {
            Console.WriteLine("Fetches the XML document that saves the data. If no file is found, it automatically creates a new one.");
        }

        public void ThrowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
