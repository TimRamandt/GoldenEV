using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class VersionCommand : Command
    {
        public VersionCommand(string[] parameters) : base(parameters) { }

        public override void Execute()
        {
            if (!IsHelpRequested)
            {
                string version = ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),
                            typeof(AssemblyFileVersionAttribute), false)).Version;
                WriteTimeStamp($"Current version: {version}");
            } 
        }

        public override void Help()
        {
            Console.WriteLine("Displays the current version of the application.");
        }

    }
}
