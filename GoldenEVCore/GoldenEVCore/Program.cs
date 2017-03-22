using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.CommandLine;

namespace GoldenEVCore
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLineInterface CLI = new CommandLineInterface();
            CLI.Intro();
            CLI.Run();
        }
    }
}
