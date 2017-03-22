using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenEVCore.DataLayer;

namespace GoldenEVCore.CommandLine.Commands
{
    class InitCommand : ICommand
    {
        public void Execute()
        {
            DataSource source = new DataSource();
            source.InitializeSource();
            Console.WriteLine("[{0}] successfull initialization of datascource", DateTime.Now);
        }
    }
}
