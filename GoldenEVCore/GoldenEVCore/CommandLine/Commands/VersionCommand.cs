using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.CommandLine.Commands
{
    class VersionCommand : ICommand
    {
        public void Execute()
        {
            string version = ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),
            typeof(AssemblyFileVersionAttribute), false)).Version;
            Console.WriteLine("Current version: " + version);
        }
    }
}
